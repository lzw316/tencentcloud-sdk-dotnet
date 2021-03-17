/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendMessagesRequest : AbstractModel
    {
        
        /// <summary>
        /// Token 是用来做鉴权使用的
        /// </summary>
        [JsonProperty("StringToken")]
        public string StringToken{ get; set; }

        /// <summary>
        /// 消息要发送的topic的名字
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 要发送的消息的内容
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// 设置 producer 的名字，要求全局唯一，用户不配置，系统会随机生成
        /// </summary>
        [JsonProperty("ProducerName")]
        public string ProducerName{ get; set; }

        /// <summary>
        /// 设置消息发送的超时时间，默认为30s
        /// </summary>
        [JsonProperty("SendTimeout")]
        public long? SendTimeout{ get; set; }

        /// <summary>
        /// 内存中缓存的最大的生产消息的数量，默认为1000条
        /// </summary>
        [JsonProperty("MaxPendingMessages")]
        public long? MaxPendingMessages{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StringToken", this.StringToken);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "ProducerName", this.ProducerName);
            this.SetParamSimple(map, prefix + "SendTimeout", this.SendTimeout);
            this.SetParamSimple(map, prefix + "MaxPendingMessages", this.MaxPendingMessages);
        }
    }
}
