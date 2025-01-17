﻿namespace GeekDesk.Constant
{
    internal class RunTimeStatus
    {

        /// <summary>
        /// 查询框是否在工作
        /// </summary>
        public static bool SEARCH_BOX_SHOW = false;

        /// <summary>
        /// 贴边隐藏后  以非鼠标经过方式触发显示
        /// </summary>
        public static bool MARGIN_HIDE_AND_OTHER_SHOW = false;


        /// <summary>
        /// 是否锁定主面板 锁定后 不执行隐藏动作
        /// </summary>
        public static bool LOCK_APP_PANEL = false;


        /// <summary>
        /// 是否弹出了菜单密码框
        /// </summary>
        public static bool SHOW_MENU_PASSWORDBOX = false;

        /// <summary>
        /// 是否弹出了右键菜单
        /// </summary>
        public static bool SHOW_RIGHT_BTN_MENU = false;

        /// <summary>
        /// 是否点击了面板功能按钮
        /// </summary>
        public static bool APP_BTN_IS_DOWN = false;

        /// <summary>
        /// 是否正在编辑菜单
        /// </summary>
        public static bool IS_MENU_EDIT = false;


        /// <summary>
        /// 图标card 鼠标滚轮是否正在工作  
        /// 用来控制popup的显示 否则低性能机器会造成卡顿
        /// </summary>
        public static bool ICONLIST_MOUSE_WHEEL = false;
        /// <summary>
        /// 控制多少毫秒后 关闭(ICONLIST_MOUSE_WHEEL)鼠标滚轮运行状态
        /// </summary>
        public static int MOUSE_WHEEL_WAIT_MS = 100;
        /// <summary>
        /// 与关闭popup 配合使用, 避免线程结束后不显示popup
        /// </summary>
        public static bool MOUSE_ENTER_ICON = false;
        /// <summary>
        /// 控制每次刷新搜索结果 鼠标移动后显示popup
        /// </summary>
        public static int MOUSE_MOVE_COUNT = 0;
    }
}
