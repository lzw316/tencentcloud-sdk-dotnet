/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductIngestTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>接入任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>接入任务信息</p>
        /// </summary>
        [JsonProperty("ProductIngestTaskItem")]
        public ProductIngestTaskItem ProductIngestTaskItem{ get; set; }

        /// <summary>
        /// <p>接入实例选择方式</p><p>枚举值：</p><ul><li>0： 全部实例</li><li>1： 按标签筛选</li><li>2： 手动选择</li></ul>
        /// </summary>
        [JsonProperty("SelectionMode")]
        public ulong? SelectionMode{ get; set; }

        /// <summary>
        /// <p>所选实例id列表</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>所选接入实例所处范围标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>eBPF 采集规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EBPFCollectRule")]
        public EBPFCollectRule EBPFCollectRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "ProductIngestTaskItem.", this.ProductIngestTaskItem);
            this.SetParamSimple(map, prefix + "SelectionMode", this.SelectionMode);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "EBPFCollectRule.", this.EBPFCollectRule);
        }
    }
}

