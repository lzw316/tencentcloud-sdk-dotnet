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

    public class OccupiedSeal : AbstractModel
    {
        
        /// <summary>
        /// 电子印章编号
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// 电子印章名称
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 电子印章授权时间戳，单位秒
        /// </summary>
        [JsonProperty("CreateOn")]
        public long? CreateOn{ get; set; }

        /// <summary>
        /// 电子印章授权人的UserId
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 电子印章策略Id
        /// </summary>
        [JsonProperty("SealPolicyId")]
        public string SealPolicyId{ get; set; }

        /// <summary>
        /// 印章状态，有以下六种：CHECKING（审核中）SUCCESS（已启用）FAIL（审核拒绝）CHECKING-SADM（待超管审核）DISABLE（已停用）STOPPED（已终止）
        /// </summary>
        [JsonProperty("SealStatus")]
        public string SealStatus{ get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 印章图片url，5分钟内有效
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 印章类型,OFFICIAL-企业公章, CONTRACT-合同专用章,ORGANIZATIONSEAL-企业印章(本地上传印章类型),LEGAL_PERSON_SEAL-法人印章
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 用印申请是否为永久授权，true-是，false-否
        /// </summary>
        [JsonProperty("IsAllTime")]
        public bool? IsAllTime{ get; set; }

        /// <summary>
        /// 授权人列表
        /// </summary>
        [JsonProperty("AuthorizedUsers")]
        public AuthorizedUser[] AuthorizedUsers{ get; set; }

        /// <summary>
        /// 印章扩展数据信息
        /// </summary>
        [JsonProperty("ExtendScene")]
        public ExtendScene ExtendScene{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamSimple(map, prefix + "CreateOn", this.CreateOn);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "SealPolicyId", this.SealPolicyId);
            this.SetParamSimple(map, prefix + "SealStatus", this.SealStatus);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "IsAllTime", this.IsAllTime);
            this.SetParamArrayObj(map, prefix + "AuthorizedUsers.", this.AuthorizedUsers);
            this.SetParamObj(map, prefix + "ExtendScene.", this.ExtendScene);
        }
    }
}

