﻿namespace Masa.Docs.Shared.Examples.components.cascaders
{
    public class Usage : Masa.Docs.Shared.Components.Usage
    {
        public Usage() : base(typeof(MCascader<CascaderNode, string>)) { }

        protected override Dictionary<string, object>? GenAdditionalParameters()
        {
            return new Dictionary<string, object>()
            {
              { nameof(MCascader<CascaderNode, string>.Items), _items },
              { nameof(MCascader<CascaderNode, string>.ItemText), (Func<CascaderNode,string>)(x=>x.Label) },
              { nameof(MCascader<CascaderNode, string>.ItemValue), (Func<CascaderNode,string>)(x=>x.Value) },
              { nameof(MCascader<CascaderNode, string>.ItemChildren), (Func<CascaderNode,List<CascaderNode>>)(x=>x.Children) },
            };
        }

        public class CascaderNode
        {
            public string Value { get; set; }
            public string Label { get; set; }
            public List<CascaderNode> Children { get; set; }
        }

        private List<CascaderNode> _items = new List<CascaderNode>() {
        new CascaderNode()
        {
            Value = "1",
            Label = "湖北",
            Children = new List<CascaderNode>() {
                    new CascaderNode{ Value = "11", Label="武汉", Children = new List<CascaderNode>(){
                        new CascaderNode{ Value = "111", Label="武昌区", Children = new List<CascaderNode>(){
                            new CascaderNode{ Value = "1111", Label="黄鹤楼街道"},
                            new CascaderNode{ Value = "1112", Label="白沙洲街道"}
                        } },
                        new CascaderNode{ Value = "112", Label="洪山区"}
                    } },
                    new CascaderNode{ Value = "12", Label="黄石"},
                    new CascaderNode{ Value = "13", Label="宜昌"}
                }
        }, new CascaderNode()
        {
            Value = "2",
            Label = "浙江",
            Children = new List<CascaderNode>() {
                    new CascaderNode{ Value = "21", Label="杭州"},
                    new CascaderNode{ Value = "22", Label="温州"},
                    new CascaderNode{ Value = "23", Label="义乌"},
                    new CascaderNode{ Value = "24", Label="宁波"}
                }
        }, new CascaderNode()
        {
            Value = "3",
            Label = "上海",
            Children = new List<CascaderNode>() {
                    new CascaderNode{ Value = "31", Label="徐汇区"},
                    new CascaderNode{ Value = "32", Label="黄浦区"},
                    new CascaderNode{ Value = "33", Label="浦东新区"},
                    new CascaderNode{ Value = "34", Label="崇明区"}
                }
        }, new CascaderNode()
        {
            Value = "4",
            Label = "北京",
            Children = new List<CascaderNode>() {
                    new CascaderNode{ Value = "41", Label="朝阳"},
                    new CascaderNode{ Value = "42", Label="东城"},
                    new CascaderNode{ Value = "43", Label="西城"}
                }
        }, new CascaderNode()
        {
            Value = "5",
            Label = "江苏",
            Children = new List<CascaderNode>() {
                    new CascaderNode{ Value = "51", Label="南京", Children = new List<CascaderNode>(){
                        new CascaderNode{ Value = "511", Label="鼓楼区"},
                        new CascaderNode{ Value = "512", Label="玄武区"}
                    } },
                    new CascaderNode{ Value = "52", Label="苏州"},
                    new CascaderNode{ Value = "53", Label="无锡"},
                    new CascaderNode{ Value = "54", Label="扬州"}
                }
        }};
    }
}
