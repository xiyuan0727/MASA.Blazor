﻿using BlazorComponent;
using System.Linq;

namespace MASA.Blazor
{
    public partial class MFileInput : BUpload
    {
        protected override void SetComponentClass()
        {
            CssProvider
                .AsProvider<BUpload>()
                .Apply(css => { }, style =>
                {
                    style.Add("display: inline-block");
                })
                .Apply("chips-wrapper", css => { }, style =>
                {
                    style.Add("padding: 8px 0");
                });

            SlotProvider
                .Apply<BList, MList>(prop =>
                {
                    prop[nameof(MList.Style)] = Files.Any() ? "" : "padding:0";
                    prop[nameof(MList.Dense)] = true;
                })
                .Apply<BListItem, MListItem>()
                .Apply<BListItemContent, MListItemContent>()
                .Apply<BListItemIcon, MListItemIcon>()
                .Apply<BListItemTitle, MListItemTitle>()
                .Apply<BListItemAction, MListItemAction>(prop =>
                {
                    prop[nameof(MListItemAction.Style)] = "margin: 0px";
                })
                .Apply<BButton, MButton>()
                .Apply<BIcon, MIcon>()
                .Apply<BHitMessage, MHitMessage>(prop =>
                {
                    prop[nameof(MHitMessage.Style)] = "text-align: right";
                })
                .Apply<BChip, MChip>(prop =>
                {
                    prop[nameof(MChip.Style)] = "margin: 0 4px 4px 0";
                })
                .Apply<BAvatar, MAvatar>(prop =>
                {
                    prop[nameof(MAvatar.Style)] = "margin-right: 4px";
                })
                .Apply<BAvatar, MListItemAvatar>("list-item")
                .Apply<BTooltip, MTooltip>();
        }

        protected override string GetColorCss(bool uploaded) => uploaded ? "" : "red--text";

        protected override string GetListItemStyle(bool uploaded) => $"border: 1px solid {(uploaded ? "lightgrey" : "#F44336")}; border-radius:4px; margin-top:4px;";

    }
}