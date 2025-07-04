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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFlowBlockchainEvidenceUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 二维码图片下载链接，下载链接有效时间5分钟，请尽快下载保存。
        /// </summary>
        [JsonProperty("QrCode")]
        public string QrCode{ get; set; }

        /// <summary>
        /// 查看短链，可直接点击短链查看证书。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 二维码和短链的过期时间戳，过期时间默认为生成链接后7天。
        /// </summary>
        [JsonProperty("ExpiredOn")]
        public ulong? ExpiredOn{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QrCode", this.QrCode);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ExpiredOn", this.ExpiredOn);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

