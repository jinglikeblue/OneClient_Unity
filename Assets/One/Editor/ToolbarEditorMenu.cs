using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace OneEditor
{
    /// <summary>
    /// One编辑器菜单
    /// </summary>
    public class ToolbarEditorMenu
    {
        [MenuItem("One/Tools", false, 0)]
        public static void ToolsWin()
        {
            OneToolsEditorWin.Open();
        }
    }
}