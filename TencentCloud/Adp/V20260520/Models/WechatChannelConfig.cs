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

    public class WechatChannelConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>授权二维码URL（创建后回填）</p>
        /// </summary>
        [JsonProperty("QrcodeUrl")]
        public string QrcodeUrl{ get; set; }

        /// <summary>
        /// <p>公众号/小程序AppId（授权后回填）</p>
        /// </summary>
        [JsonProperty("WechatAppId")]
        public string WechatAppId{ get; set; }

        /// <summary>
        /// <p>公众号/小程序RefreshToken（授权后回填）</p>
        /// </summary>
        [JsonProperty("WechatRefreshToken")]
        public string WechatRefreshToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QrcodeUrl", this.QrcodeUrl);
            this.SetParamSimple(map, prefix + "WechatAppId", this.WechatAppId);
            this.SetParamSimple(map, prefix + "WechatRefreshToken", this.WechatRefreshToken);
        }
    }
}

