﻿using System;
using System.Collections.Generic;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Navigation;

public class MenuViewModel
{
    public ApplicationMenu Menu { get; set; }

    public IList<MenuItemViewModel> Items { get; set; }

    public EventHandler StateChanged;

    public void SetParents()
    {
        foreach (var item in Items)
        {
            item.SetParents(null);
        }
    }

    public void ToggleOpen(MenuItemViewModel menuItem)
    {
        if (menuItem.IsOpen)
        {
            menuItem.Close();
        }
        else
        {
            CloseAll();
            menuItem.Open();
        }

        StateChanged.InvokeSafely(this);
    }

    public void Activate(MenuItemViewModel menuItem)
    {
        if (menuItem.IsActive)
        {
            return;
        }

        DeactivateAll();
        menuItem.Open();
        menuItem.Activate();
        StateChanged.InvokeSafely(this);
    }

    private void CloseAll()
    {
        foreach (var item in Items)
        {
            item.Close();
        }
    }

    private void DeactivateAll()
    {
        foreach (var item in Items)
        {
            item.Deactivate();
        }
    }
}