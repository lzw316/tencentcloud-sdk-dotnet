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

    public class FlowApproverUrlInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署短链接。
        /// 注意:
        /// 1. 该链接有效期为<b>30分钟</b>，同时需要注意保密，不要外泄给无关用户。
        /// 2. 该链接不支持小程序嵌入，仅支持<b>移动端浏览器</b>打开。
        /// 3. <font color="red">生成的链路后面不能再增加参数</font>（会出现覆盖链接中已有参数导致错误）
        /// </summary>
        [JsonProperty("SignUrl")]
        public string SignUrl{ get; set; }

        /// <summary>
        /// 签署人类型。
        /// - **1**: 个人
        /// </summary>
        [JsonProperty("ApproverType")]
        public long? ApproverType{ get; set; }

        /// <summary>
        /// 签署人姓名。
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// 签署人手机号。
        /// </summary>
        [JsonProperty("ApproverMobile")]
        public string ApproverMobile{ get; set; }

        /// <summary>
        /// 签署长链接。
        /// 注意:
        /// 1. 该链接有效期为**30分钟**，同时需要注意保密，不要外泄给无关用户。
        /// 2. 该链接不支持小程序嵌入，仅支持**移动端浏览器**打开。
        /// 3. <font color="red">生成的链路后面不能再增加参数</font>（会出现覆盖链接中已有参数导致错误）
        /// </summary>
        [JsonProperty("LongUrl")]
        public string LongUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignUrl", this.SignUrl);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproverMobile", this.ApproverMobile);
            this.SetParamSimple(map, prefix + "LongUrl", this.LongUrl);
        }
    }
}

