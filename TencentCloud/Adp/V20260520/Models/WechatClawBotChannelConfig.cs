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

    public class WechatClawBotChannelConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>ClawBot机器人ID（扫码后回填）</p>
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// <p>ClawBot机器人Token（扫码后回填）</p>
        /// </summary>
        [JsonProperty("BotToken")]
        public string BotToken{ get; set; }

        /// <summary>
        /// <p>二维码状态（wait/confirmed/expired）</p>
        /// </summary>
        [JsonProperty("QrcodeStatus")]
        public string QrcodeStatus{ get; set; }

        /// <summary>
        /// <p>二维码URL（创建后回填）</p>
        /// </summary>
        [JsonProperty("QrcodeUrl")]
        public string QrcodeUrl{ get; set; }

        /// <summary>
        /// <p>微信用户ID（扫码后回填）</p>
        /// </summary>
        [JsonProperty("WechatUserId")]
        public string WechatUserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "BotToken", this.BotToken);
            this.SetParamSimple(map, prefix + "QrcodeStatus", this.QrcodeStatus);
            this.SetParamSimple(map, prefix + "QrcodeUrl", this.QrcodeUrl);
            this.SetParamSimple(map, prefix + "WechatUserId", this.WechatUserId);
        }
    }
}

