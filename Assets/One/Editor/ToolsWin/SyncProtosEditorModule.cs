using Jing;
using marijnz.EditorCoroutines;
using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroEditor;

public class SyncProtosEditorModule : AEditorModule
{
    /// <summary>
    /// 配置文件位置
    /// </summary>
    public const string CONFIG_NAME = "one_sync_protos_config.json";

    public class ConfigVO
    {
        public string[] protoSources = new string[0];
        public string protoDir = "";
        public string generateToolEXE = "";
        public string localClassDir = "";
    }

    /// <summary>
    /// 加载配置
    /// </summary>
    /// <returns></returns>
    public static ConfigVO LoadConfig()
    {
        var cfg = EditorConfigUtil.LoadConfig<ConfigVO>(CONFIG_NAME);
        return cfg;
    }

    ConfigVO _cfg;

    public SyncProtosEditorModule(EditorWindow editorWin) : base(editorWin)
    {
        _cfg = LoadConfig();
        protoDir = _cfg.protoDir;
        generateToolEXE = _cfg.generateToolEXE;
        localClassDir = _cfg.localClassDir;
        protoSources = _cfg.protoSources;
    }

    [LabelText("保存配置"), Button(size: ButtonSizes.Large), PropertyOrder(-1)]
    void Save()
    {
        _cfg.protoDir = protoDir;
        _cfg.generateToolEXE = generateToolEXE;
        _cfg.localClassDir = localClassDir;
        _cfg.protoSources = protoSources;
        EditorConfigUtil.SaveConfig(_cfg, CONFIG_NAME);
    }

    [Title("更新协议")]
    public string[] protoSources;

    [LabelText("协议保存目录"), FolderPath(AbsolutePath = true, ParentFolder = "@CodesParent"), InlineButton("OpenProtoDir", "打开")]
    public string protoDir;

    void OpenProtoDir()
    {
        ZeroEditorUtil.OpenDirectory(protoDir);
    }

    [ProgressBar(0, "@protoSources.Length"), ReadOnly, LabelText("下载中..."), ShowIf("ShowProgressEnable")]
    public float updateProgress = -1;

    bool ShowProgressEnable()
    {
        if(updateProgress >= 0)
        {
            return true;
        }
        return false;
    }

    [PropertySpace(10)]
    [Button(ButtonSizes.Large), LabelText("更新协议"), PropertyOrder(1)]
    void UpdateProtos()
    {
        EditorCoroutines.StartCoroutine(UpdateProtosCoroutine(),this);
    }

    IEnumerator UpdateProtosCoroutine()
    {
        updateProgress = 0;
        int i = 0;        

        foreach (var protoUri in protoSources)
        {
            var fileName = Path.GetFileName(protoUri);
            var savePath = FileSystem.CombinePaths(protoDir, fileName);
            Downloader loader = new Downloader(protoUri, savePath);

            while (false == loader.isDone)
            {
                //卡死线程
                yield return null;
            }

            updateProgress = ++i;
        }
        updateProgress = -1;
    }

    public override void OnDisable()
    {
        base.OnDisable();
        EditorCoroutines.StopAllCoroutines(this);
    }

    [Title("生成协议"), PropertyOrder(2)]
    [LabelText("生成工具"), FilePath(AbsolutePath = true, ParentFolder = "@UnityEngine.Application.dataPath", Extensions = ".exe")]
    public string generateToolEXE;

    [LabelText("项目代码目录(Assets中的)"), FolderPath(AbsolutePath = true, ParentFolder = "@CodesParent"), PropertyOrder(2)]
    public string localClassDir;

    [PropertySpace(10)]
    [Button(ButtonSizes.Large), LabelText("生成代码"), PropertyOrder(3)]
    void GenerateCodes()
    {
        if(Application.platform != RuntimePlatform.WindowsEditor)
        {
            editorWin.ShowTip("目前只能在Windows系统下生成代码");
            return;
        }

        using(Process p = new Process())
        {
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(generateToolEXE);
            p.StartInfo.FileName = generateToolEXE;
            p.StartInfo.Arguments = localClassDir;
            p.Start();
            p.WaitForExit();
        }
        AssetDatabase.Refresh();
        editorWin.ShowTip("完成");
    }

    static string CodesParent
    {
        get
        {
            return FileSystem.CombineDirs(true, Application.dataPath, "assets");
        }
    }
}
