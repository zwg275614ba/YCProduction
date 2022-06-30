using System;
using System.Collections.Generic;
using System.Text;

namespace YCProduction.Common.Tree
{
    public class NodeTree
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        public int? id { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 父ID
        /// </summary>
        public int? pId { get; set; }
        /// <summary>
        /// 是否有子节点
        /// </summary>
        public bool isParent { get; set; }
        /// <summary>
        /// 是否展开
        /// </summary>
        public bool open { get; set; }
        /// <summary>
        /// 设置节点是否隐藏 checkbox / radio
        /// </summary>
        public bool nocheck { get; set; }
        /// <summary>
        /// 是否选中checkbox / radio
        /// </summary>
        public bool @checked { get; set; }
    }
}
