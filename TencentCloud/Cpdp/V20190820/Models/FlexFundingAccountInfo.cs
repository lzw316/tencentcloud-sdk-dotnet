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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlexFundingAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 资金账户号
        /// </summary>
        [JsonProperty("FundingAccountNo")]
        public string FundingAccountNo{ get; set; }

        /// <summary>
        /// 资金账户类型
        /// </summary>
        [JsonProperty("FundingAccountType")]
        public string FundingAccountType{ get; set; }

        /// <summary>
        /// 资金账户绑定序列号
        /// </summary>
        [JsonProperty("FundingAccountBindSerialNo")]
        public string FundingAccountBindSerialNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FundingAccountNo", this.FundingAccountNo);
            this.SetParamSimple(map, prefix + "FundingAccountType", this.FundingAccountType);
            this.SetParamSimple(map, prefix + "FundingAccountBindSerialNo", this.FundingAccountBindSerialNo);
        }
    }
}
