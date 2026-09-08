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

    public class CreateResourceGraphProductIngestTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源图谱id</p>
        /// </summary>
        [JsonProperty("ResourceGraphId")]
        public string ResourceGraphId{ get; set; }

        /// <summary>
        /// <p>接入任务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>待接入的云产品；支持tke、cdb、mongodb、redis</p>
        /// </summary>
        [JsonProperty("CloudProduct")]
        public string CloudProduct{ get; set; }

        /// <summary>
        /// <p>实例选择方案</p><p>枚举值：</p><ul><li>0： 所有示例</li><li>1： 按标签选择</li><li>2： 手动选择</li></ul>
        /// </summary>
        [JsonProperty("SelectionMode")]
        public ulong? SelectionMode{ get; set; }

        /// <summary>
        /// <p>实例id。当选择方式使用“指定实例”时，需要填写</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>eBPF 采集规则</p>
        /// </summary>
        [JsonProperty("EBPFCollectRule")]
        public EBPFCollectRule EBPFCollectRule{ get; set; }

        /// <summary>
        /// <p>标签。当实例选择方案使用“按标签选择”时，需要填写</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGraphId", this.ResourceGraphId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CloudProduct", this.CloudProduct);
            this.SetParamSimple(map, prefix + "SelectionMode", this.SelectionMode);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "EBPFCollectRule.", this.EBPFCollectRule);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

