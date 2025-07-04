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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainAndRecordListRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索所有域名。AllDomain、GroupIdList、DomainList、DomainIdList 参数传任一个即可。优先级为：AllDomain > GroupIdList  > DomainList > DomainIdList。
        /// </summary>
        [JsonProperty("AllDomain")]
        public string AllDomain{ get; set; }

        /// <summary>
        /// 要搜索的域名列表。
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// 要搜索的域名 ID 列表。
        /// </summary>
        [JsonProperty("DomainIdList")]
        public ulong?[] DomainIdList{ get; set; }

        /// <summary>
        /// 要搜索的域名分组 ID 列表。
        /// </summary>
        [JsonProperty("GroupIdList")]
        public ulong?[] GroupIdList{ get; set; }

        /// <summary>
        /// 记录类型筛选
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// 子域名筛选
        /// </summary>
        [JsonProperty("SubKeyword")]
        public string SubKeyword{ get; set; }

        /// <summary>
        /// 记录值筛选
        /// </summary>
        [JsonProperty("ValueKeyword")]
        public string ValueKeyword{ get; set; }

        /// <summary>
        /// 线路筛选
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 备注筛选
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 记录状态筛选
        /// 1：正常
        /// 0：暂停
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllDomain", this.AllDomain);
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
            this.SetParamArraySimple(map, prefix + "DomainIdList.", this.DomainIdList);
            this.SetParamArraySimple(map, prefix + "GroupIdList.", this.GroupIdList);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "SubKeyword", this.SubKeyword);
            this.SetParamSimple(map, prefix + "ValueKeyword", this.ValueKeyword);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

