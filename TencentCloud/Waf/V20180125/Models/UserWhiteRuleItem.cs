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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserWhiteRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 匹配域
        /// </summary>
        [JsonProperty("MatchField")]
        public string MatchField{ get; set; }

        /// <summary>
        /// 匹配方法
        /// </summary>
        [JsonProperty("MatchMethod")]
        public string MatchMethod{ get; set; }

        /// <summary>
        /// 匹配内容
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }

        /// <summary>
        /// 匹配参数名
        /// </summary>
        [JsonProperty("MatchParams")]
        public string MatchParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchField", this.MatchField);
            this.SetParamSimple(map, prefix + "MatchMethod", this.MatchMethod);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
            this.SetParamSimple(map, prefix + "MatchParams", this.MatchParams);
        }
    }
}

