using Jing;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using ZeroEditor;

public class SyncProtosEditorModule : AEditorModule
{
    public SyncProtosEditorModule(EditorWindow editorWin) : base(editorWin)
    {

    }

    [Title("更新协议")]
    public string[] protoSources;

    [Title("生成协议")]
    [LabelText("生成工具"), FilePath(AbsolutePath = true, Extensions = ".exe")]
    public string generateToolEXE;

    [LabelText("项目代码目录(Assets中的)"), FolderPath(AbsolutePath = true, ParentFolder = "@CodesParent")]
    public string localClassDir;

    [Button(ButtonSizes.Large), LabelText("同步")]
    void Sync()
    {

    }

    string CodesParent
    {
        get
        {
            return FileSystem.CombineDirs(true, Application.dataPath, "assets");
        }
    }
}
