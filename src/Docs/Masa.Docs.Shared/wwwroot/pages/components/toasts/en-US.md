---
title: Toast
desc: "The component is used to convey important information to the user through the use contextual types icons and color.These default types come in in 4 variations: `Success`,`Info`,`Warning`, and `Error`. Default icons are assigned which help represent different actions each type portrays and also can customized content to fit almost any situation."
related:
  - /components/cards
  - /components/icons
  - /components/grid-system
---

## Usage

The **PToast** component can be used by PopupService, see the documentation of [PopupService](/components/popup-service) for details.

<toast-usage></toast-usage>

## Examples

### Props

#### Duration (default 4000ms)

<masa-example file="Examples.components.toast.Duration"></masa-example>

#### MaxCount

`MaxCount` prop Set the maximum number of impressions。

<masa-example file="Examples.components.toast.MaxCount"></masa-example>

#### Toast Position

`Value` prop Set the location of the message popup。

<masa-example file="Examples.components.toast.Position"></masa-example>

### Event

#### Custom Toast content

<masa-example file="Examples.components.toast.CustomToast"></masa-example>