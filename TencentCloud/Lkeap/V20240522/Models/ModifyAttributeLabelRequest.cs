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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAttributeLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 属性ID
        /// </summary>
        [JsonProperty("AttributeId")]
        public string AttributeId{ get; set; }

        /// <summary>
        /// 属性标识，最大40个英文字符，如style
        /// </summary>
        [JsonProperty("AttributeKey")]
        public string AttributeKey{ get; set; }

        /// <summary>
        /// 属性名称，最大80个英文字符，如风格
        /// </summary>
        [JsonProperty("AttributeName")]
        public string AttributeName{ get; set; }

        /// <summary>
        /// 属性标签
        /// </summary>
        [JsonProperty("Labels")]
        public AttributeLabelItem[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "AttributeId", this.AttributeId);
            this.SetParamSimple(map, prefix + "AttributeKey", this.AttributeKey);
            this.SetParamSimple(map, prefix + "AttributeName", this.AttributeName);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

