﻿using UnityEngine;
using VRC.UI.Elements.Controls;

namespace VRChatUtilityKit.Ui
{
    // Credit for Slaynash (https://gist.github.com/Slaynash/018d6de4e8d27faf08c0fe4a6c2854de) to act as reference
    /// <summary>
    /// A wrapper that holds a tab button.
    /// </summary>
    public class TabButton : VRCSelectable
    {
        /// <summary>
        /// The tab menu attached to the tab button.
        /// </summary>
        public TabMenu SubMenu { get; private set; }

        /// <summary>
        /// The MenuTab component on the tab button.
        /// </summary>
        public MenuTab MenuTab { get; private set; }

        /// <summary>
        /// Creates a new tab button.
        /// </summary>
        /// <param name="sprite">The sprite of the tab button</param>
        /// <param name="pageName">The name of the tab menu's page</param>
        /// <param name="gameObjectName">The name of the tab button's GameObject</param>
        public TabButton(Sprite sprite, string pageName, string gameObjectName) : base(UiManager.QMStateController.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup").gameObject, UiManager.QMStateController.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard").gameObject, sprite, gameObjectName)
        {
            MenuTab = gameObject.GetComponent<MenuTab>();
            MenuTab._menuStateController = UiManager.QMStateController;
            MenuTab.pageName = pageName;

            SubMenu = new TabMenu(pageName, $"Page_{pageName}");
        }
    }
}
