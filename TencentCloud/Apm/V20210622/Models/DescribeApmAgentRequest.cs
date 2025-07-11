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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApmAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务系统 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 接入方式，现支持 skywalking, ot, ebpf 方式接入上报，不填默认为 ot
        /// </summary>
        [JsonProperty("AgentType")]
        public string AgentType{ get; set; }

        /// <summary>
        /// 上报环境，现支持 pl (内网上报), public (外网), inner (自研 VPC )环境上报，不传默认为 public
        /// </summary>
        [JsonProperty("NetworkMode")]
        public string NetworkMode{ get; set; }

        /// <summary>
        /// 语言，现支持 java, golang, php, python, dotNet, nodejs 语言上报，不传默认为 golang
        /// </summary>
        [JsonProperty("LanguageEnvironment")]
        public string LanguageEnvironment{ get; set; }

        /// <summary>
        /// 上报方式，已弃用
        /// </summary>
        [JsonProperty("ReportMethod")]
        public string ReportMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AgentType", this.AgentType);
            this.SetParamSimple(map, prefix + "NetworkMode", this.NetworkMode);
            this.SetParamSimple(map, prefix + "LanguageEnvironment", this.LanguageEnvironment);
            this.SetParamSimple(map, prefix + "ReportMethod", this.ReportMethod);
        }
    }
}

