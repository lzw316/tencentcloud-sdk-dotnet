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

    public class EBPFCollectFilters : AbstractModel
    {
        
        /// <summary>
        /// 进程名过滤
        /// </summary>
        [JsonProperty("ProcessName")]
        public EBPFProcessNameFilter ProcessName{ get; set; }

        /// <summary>
        /// 目的端点过滤
        /// </summary>
        [JsonProperty("DestEndpoint")]
        public EBPFDestEndpointFilter DestEndpoint{ get; set; }

        /// <summary>
        /// DNS 过滤
        /// </summary>
        [JsonProperty("DNS")]
        public EBPFDNSFilter DNS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ProcessName.", this.ProcessName);
            this.SetParamObj(map, prefix + "DestEndpoint.", this.DestEndpoint);
            this.SetParamObj(map, prefix + "DNS.", this.DNS);
        }
    }
}

