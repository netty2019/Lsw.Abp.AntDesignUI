﻿using AntDesign;
using Lsw.Abp.AspnetCore.Components.Web.AntDesignTheme.Settings;

namespace Lsw.Abp.AspnetCore.Components.Web.AntDesignTheme;

public class AbpAntDesignThemeOptions
{
    public MenuOptions Menu { get; set; }

    /// <summary>
    /// 是否启用多标签页
    /// </summary>
    public bool EnableMultipleTabs { get; set; }

    public AbpAntDesignThemeOptions()
    {
        Menu = new MenuOptions();
    }
}

public class MenuOptions
{
    public MenuTheme Theme { get; set; }

    public MenuPlacement Placement { get; set; }

    public MenuOptions()
    {
        Theme = MenuTheme.Dark;
        Placement = MenuPlacement.Left;
    }
}
