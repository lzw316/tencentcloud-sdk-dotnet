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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceSecurityGroupPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 安全组实例ID，例如sg-33ocnj9n，可通过DescribeSecurityGroups获取。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// 安全组规则集合对象。
        /// </summary>
        [JsonProperty("SecurityGroupPolicySet")]
        public SecurityGroupPolicySet SecurityGroupPolicySet{ get; set; }

        /// <summary>
        /// 旧的安全组规则集合对象，可选，日志记录用。
        /// </summary>
        [JsonProperty("OriginalSecurityGroupPolicySet")]
        public SecurityGroupPolicySet OriginalSecurityGroupPolicySet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamObj(map, prefix + "SecurityGroupPolicySet.", this.SecurityGroupPolicySet);
            this.SetParamObj(map, prefix + "OriginalSecurityGroupPolicySet.", this.OriginalSecurityGroupPolicySet);
        }
    }
}
