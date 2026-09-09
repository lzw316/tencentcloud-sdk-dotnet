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

    public class WecomRobotCallbackAccess : AbstractModel
    {
        
        /// <summary>
        /// <p>回调配置</p>
        /// </summary>
        [JsonProperty("Callback")]
        public CallbackConfig Callback{ get; set; }

        /// <summary>
        /// <p>机器人名称</p>
        /// </summary>
        [JsonProperty("RobotName")]
        public string RobotName{ get; set; }

        /// <summary>
        /// <p>企微企业ID</p>
        /// </summary>
        [JsonProperty("WecomCorpId")]
        public string WecomCorpId{ get; set; }

        /// <summary>
        /// <p>企微机器人ID</p>
        /// </summary>
        [JsonProperty("WecomRobotId")]
        public string WecomRobotId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
            this.SetParamSimple(map, prefix + "RobotName", this.RobotName);
            this.SetParamSimple(map, prefix + "WecomCorpId", this.WecomCorpId);
            this.SetParamSimple(map, prefix + "WecomRobotId", this.WecomRobotId);
        }
    }
}

