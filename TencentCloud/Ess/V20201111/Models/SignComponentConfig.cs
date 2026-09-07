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

    public class SignComponentConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>签署控件默认属性配置，是否默认展示签署日期， 在页面中可以进行修改。</p><ul><li>false 展示签署日期（默认）</li><li>true 不展示签署日期<br><img src="https://qcloudimg.tencent-cloud.cn/raw/448514412e2f69f6129425beda4ff568.png" alt="image">。</li></ul>
        /// </summary>
        [JsonProperty("HideDate")]
        public bool? HideDate{ get; set; }

        /// <summary>
        /// <p>【仅 SignBeanTag=1 时有效】 签署方自行添加签署印章类控件（SIGN_SEAL、SIGN_PAGING_SEAL、SIGN_LEGAL_PERSON_SEAL）时，「盖章区适配签署方印章尺寸」开关的控制策略</p><p>枚举值：</p><ul><li>0： 默认关闭，可开启。与现网一致</li><li>1： 关闭且置灰——按控件默认的4.2cm尺寸盖章，签署方无法开启开关</li><li>2： 默认开启且可修改——默认按印章实际尺寸盖章，签署方可手动关闭</li><li>3： 开启且置灰——强制按印章实际尺寸盖章，签署方不可修改</li></ul>
        /// </summary>
        [JsonProperty("AddSignComponentUseSealSize")]
        public ulong? AddSignComponentUseSealSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HideDate", this.HideDate);
            this.SetParamSimple(map, prefix + "AddSignComponentUseSealSize", this.AddSignComponentUseSealSize);
        }
    }
}

