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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CollectorOutputInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>采集器输出的实例类型（支持elasticsearch、logstash）</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>采集器输出的实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>采集器输出到的ES实例的用户名</p>
        /// </summary>
        [JsonProperty("ESUserName")]
        public string ESUserName{ get; set; }

        /// <summary>
        /// <p>采集器输出到的ES实例的密码</p>
        /// </summary>
        [JsonProperty("ESUserPasswd")]
        public string ESUserPasswd{ get; set; }

        /// <summary>
        /// <p>采集器输出到ES实例时，是否开启监控（1为开启，0为不开启，默认为0）</p>
        /// </summary>
        [JsonProperty("EnableMonitoring")]
        public long? EnableMonitoring{ get; set; }

        /// <summary>
        /// <p>采集器输出到ES实例时，是否开启自动在kibana中生成Dashboard（1为开启，0为不开启，默认为0）</p>
        /// </summary>
        [JsonProperty("EnableDashboard")]
        public long? EnableDashboard{ get; set; }

        /// <summary>
        /// <p>Ckafka实例的vip</p>
        /// </summary>
        [JsonProperty("KafkaEndpoint")]
        public string KafkaEndpoint{ get; set; }

        /// <summary>
        /// <p>Ckafka实例中的Topic</p>
        /// </summary>
        [JsonProperty("KafkaTopic")]
        public string KafkaTopic{ get; set; }

        /// <summary>
        /// <p>Ckafka实例的版本号</p>
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// <p>topic id</p>
        /// </summary>
        [JsonProperty("SesTopicId")]
        public string SesTopicId{ get; set; }

        /// <summary>
        /// <p>topic name</p>
        /// </summary>
        [JsonProperty("SesTopicName")]
        public string SesTopicName{ get; set; }

        /// <summary>
        /// <p>topic address</p>
        /// </summary>
        [JsonProperty("SesTopicAddress")]
        public string SesTopicAddress{ get; set; }

        /// <summary>
        /// <p>/</p>
        /// </summary>
        [JsonProperty("SesTopicUserName")]
        public string SesTopicUserName{ get; set; }

        /// <summary>
        /// <p>/</p>
        /// </summary>
        [JsonProperty("SesTopicPasswd")]
        public string SesTopicPasswd{ get; set; }

        /// <summary>
        /// <p>/</p>
        /// </summary>
        [JsonProperty("LogstashListenPort")]
        public ulong? LogstashListenPort{ get; set; }

        /// <summary>
        /// <p>serverless 的 spaceid</p>
        /// </summary>
        [JsonProperty("SesSpaceId")]
        public string SesSpaceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ESUserName", this.ESUserName);
            this.SetParamSimple(map, prefix + "ESUserPasswd", this.ESUserPasswd);
            this.SetParamSimple(map, prefix + "EnableMonitoring", this.EnableMonitoring);
            this.SetParamSimple(map, prefix + "EnableDashboard", this.EnableDashboard);
            this.SetParamSimple(map, prefix + "KafkaEndpoint", this.KafkaEndpoint);
            this.SetParamSimple(map, prefix + "KafkaTopic", this.KafkaTopic);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SesTopicId", this.SesTopicId);
            this.SetParamSimple(map, prefix + "SesTopicName", this.SesTopicName);
            this.SetParamSimple(map, prefix + "SesTopicAddress", this.SesTopicAddress);
            this.SetParamSimple(map, prefix + "SesTopicUserName", this.SesTopicUserName);
            this.SetParamSimple(map, prefix + "SesTopicPasswd", this.SesTopicPasswd);
            this.SetParamSimple(map, prefix + "LogstashListenPort", this.LogstashListenPort);
            this.SetParamSimple(map, prefix + "SesSpaceId", this.SesSpaceId);
        }
    }
}

