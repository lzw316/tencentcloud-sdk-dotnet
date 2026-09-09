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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillCorpShareConfig : AbstractModel
    {
        
        /// <summary>
        /// <table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>SHARE_SCOPE_TYPE_UNSPECIFIED</td><td>0</td><td></td></tr><tr><td>SHARE_SCOPE_TYPE_ALL</td><td>1</td><td></td></tr><tr><td>SHARE_SCOPE_TYPE_ACCOUNT</td><td>2</td><td></td></tr><tr><td>SHARE_SCOPE_TYPE_SPACE</td><td>3</td><td></td></tr></tbody></table><p>枚举值：</p><ul><li>0： 未指定</li><li>1： 全企业共享</li><li>3： 按空间共享</li></ul>
        /// </summary>
        [JsonProperty("ShareScope")]
        public long? ShareScope{ get; set; }

        /// <summary>
        /// <p>共享范围信息，仅支持空间；StrId 为空间ID，Name 为空间名称</p>
        /// </summary>
        [JsonProperty("ShareScopeList")]
        public Identity[] ShareScopeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShareScope", this.ShareScope);
            this.SetParamArrayObj(map, prefix + "ShareScopeList.", this.ShareScopeList);
        }
    }
}

