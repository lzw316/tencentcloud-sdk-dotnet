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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ControlAIConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务唯一标识</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>控制命令，目前支持命令如下：- ServerPushText，服务端发送文本给AI机器人，AI机器人会播报该文本. - InvokeLLM，服务端发送文本给大模型，触发对话。- TransparentData，透传信息给客户端。</p>
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// <p>服务端发送播报文本命令，当Command为ServerPushText时必填</p>
        /// </summary>
        [JsonProperty("ServerPushText")]
        public ServerPushText ServerPushText{ get; set; }

        /// <summary>
        /// <p>服务端发送命令主动请求大模型,当Command为InvokeLLM时会把content请求到大模型,头部增加X-Invoke-LLM=&quot;1&quot;</p>
        /// </summary>
        [JsonProperty("InvokeLLM")]
        public InvokeLLM InvokeLLM{ get; set; }

        /// <summary>
        /// <p>ai对话需要透传给客户端的信息</p>
        /// </summary>
        [JsonProperty("TransparentData")]
        public TransparentData TransparentData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "ServerPushText.", this.ServerPushText);
            this.SetParamObj(map, prefix + "InvokeLLM.", this.InvokeLLM);
            this.SetParamObj(map, prefix + "TransparentData.", this.TransparentData);
        }
    }
}

