---
title: Chips（纸片）
desc: "**MChip** 组件用于传送小信息。 使用 `Close` 属性，纸片将变为交互式，允许用户进行交互。 此组件由 [MChipGroup](/components/chip-groups) 用于高级选择选项。"
related:
  - /components/avatars
  - /components/icons
  - /components/selects
---

## 使用

纸片有以下几种变化：封闭式、过滤式、轮廓式、药丸式。 **MChip** 的默认插槽也接受文本旁边的头像和图标。

<chips-usage></chips-usage>

## 示例

### 属性

#### 可关闭

可关闭的纸片默认使用 `Close` 控制。 如果您想知道纸片何时关闭也可以侦听 `OnCloseClick` 事件。

<masa-example file="Examples.components.chips.Closable"></masa-example>

#### 色彩

Material Design 调色板中的任何颜色都可用于更改纸片颜色。

<masa-example file="Examples.components.chips.Colored"></masa-example>

#### 可拖动

使用 `Draggable` 属性可以使 **MChip** 组件可以被鼠标拖拽。

<masa-example file="Examples.components.chips.Draggable"></masa-example>

#### 过滤器

**MChip** 组件有 `Filter` 属性选项，在chip处于活动状态时向您显示额外的图标。 可以使用 `FilterIcon` 来自定义。

<masa-example file="Examples.components.chips.Filter"></masa-example>

#### 标签

纸片标签使用Card的边框半径。

<masa-example file="Examples.components.chips.Label"></masa-example>

#### 无波纹

**MChip** 可以在 `Ripple` 属性被设置为 false 情况下不渲染波纹效果。

<masa-example file="Examples.components.chips.NoRipple"></masa-example>

#### 轮廓

轮廓纸片从当前文本颜色继承其边框颜色。

<masa-example file="Examples.components.chips.Outlined"></masa-example>

#### 大小

**MChip** 组件可以设置从 `XSmall` 到 `XLarge` 不同的大小。

<masa-example file="Examples.components.chips.Sizes"></masa-example>

### 事件

#### 行为纸片

纸片可以用作可操作的项目。 只要有 `OnClick` 事件，纸片就会变成可交互并且可以调用方法。

<masa-example file="Examples.components.chips.ActionChips"></masa-example>

### 插槽

#### 图标

纸片可以使用文本或 Material Icons 字体库中可用的任何图标。

<masa-example file="Examples.components.chips.Icon"></masa-example>

### 其他

#### 自定义列表

使用自定义列表使我们能够始终显示可用的选项，同时提供相同的搜索和选择功能。(暂无OnInput事件)

<masa-example file="Examples.components.chips.CustomList"></masa-example>

#### 可展开

纸片可与 **MMenu** 组合使用，为纸片启用一组特定的操作。

<masa-example file="Examples.components.chips.Expandable"></masa-example>

#### 过滤

纸片非常适合为特定任务提供辅助操作。 在本例中，我们搜索一个项目列表并收集一个子集信息以显示可用的关键字。(暂无OnInput事件)

<masa-example file="Examples.components.chips.Filtering"></masa-example>

#### 选中

选择可以使用纸片显示所选数据。 尝试在下方添加您自己的标签。

<masa-example file="Examples.components.chips.InSelects"></masa-example>

