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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BanAndAllowRuleDel : AbstractModel
    {
        
        /// <summary>
        /// 封禁和放通对象
        /// </summary>
        [JsonProperty("Ioc")]
        public string Ioc{ get; set; }

        /// <summary>
        /// 0互联网出站 1互联网入站 5内网访问源 6内网访问目的 （DeleteBlockIgnoreRuleNew接口，该字段无效）
        /// </summary>
        [JsonProperty("DirectionList")]
        public string DirectionList{ get; set; }

        /// <summary>
        /// 规则类型
        /// RuleType: 1黑名单 2外部IP 3域名 4情报 5资产 6自定义规则  7入侵防御规则
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ioc", this.Ioc);
            this.SetParamSimple(map, prefix + "DirectionList", this.DirectionList);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
        }
    }
}

