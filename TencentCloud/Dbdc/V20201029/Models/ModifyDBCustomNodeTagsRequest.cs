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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBCustomNodeTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>DB Custom 节点ID</p><p>参数格式：dbcn-0zan5xxk</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>为节点绑定的标签信息</p><p>入参限制：参考标签侧的限制</p><p>如果节点未关联输入的标签键，则增加关联；若已关联，则将该节点关联的键对应的标签值修改为输入值。本接口中 AddTags 和 DeleteTagKeys 二者必须存在其一，且二者不能包含相同的标签键。</p>
        /// </summary>
        [JsonProperty("AddTags")]
        public Tag[] AddTags{ get; set; }

        /// <summary>
        /// <p>需要解关联的标签Key</p><p>本接口中 AddTags 和 DeleteTagKeys 二者必须存在其一，且二者不能包含相同的标签键。</p>
        /// </summary>
        [JsonProperty("DeleteTagKeys")]
        public string[] DeleteTagKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamArrayObj(map, prefix + "AddTags.", this.AddTags);
            this.SetParamArraySimple(map, prefix + "DeleteTagKeys.", this.DeleteTagKeys);
        }
    }
}

