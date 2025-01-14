---
title: Tooltip
desc: "The **MTooltip** component is useful for conveying information when a user hovers over an element. You can also programmatically control the display of tooltips through a `@bind-Value`. When activated, tooltips display a text label identifying an element, such as a description of its function."
related:
  - /components/badges
  - /components/icons
  - /components/menus
---

## Usage

Tooltips can wrap any element.

<tooltips-usage></tooltips-usage>

## API

- [MTooltip](/api/MTooltip)

## Caveats

<app-alerts type="info" content="In order to correctly position **MTooltip**, a position support (`Top` | `Bottom ` |`Left ` | `Right`) is required."></app-alerts>

## Examples

### Props

#### Alignment

A tooltip can be aligned to any of the four sides of the activator element.

<masa-example file="Examples.components.tooltips.Alignment"></masa-example>

#### Visibility

Tooltip visibility can be programmatically changed using `@bind-Value`.

<masa-example file="Examples.components.tooltips.Visibility"></masa-example>