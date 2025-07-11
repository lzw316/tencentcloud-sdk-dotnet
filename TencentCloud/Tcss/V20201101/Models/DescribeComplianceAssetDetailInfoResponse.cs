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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComplianceAssetDetailInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 某资产的详情。
        /// </summary>
        [JsonProperty("AssetDetailInfo")]
        public ComplianceAssetDetailInfo AssetDetailInfo{ get; set; }

        /// <summary>
        /// 当资产为容器时，返回此字段。
        /// </summary>
        [JsonProperty("ContainerDetailInfo")]
        public ComplianceContainerDetailInfo ContainerDetailInfo{ get; set; }

        /// <summary>
        /// 当资产为镜像时，返回此字段。
        /// </summary>
        [JsonProperty("ImageDetailInfo")]
        public ComplianceImageDetailInfo ImageDetailInfo{ get; set; }

        /// <summary>
        /// 当资产为主机时，返回此字段。
        /// </summary>
        [JsonProperty("HostDetailInfo")]
        public ComplianceHostDetailInfo HostDetailInfo{ get; set; }

        /// <summary>
        /// 当资产为K8S时，返回此字段。
        /// </summary>
        [JsonProperty("K8SDetailInfo")]
        public ComplianceK8SDetailInfo K8SDetailInfo{ get; set; }

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
            this.SetParamObj(map, prefix + "AssetDetailInfo.", this.AssetDetailInfo);
            this.SetParamObj(map, prefix + "ContainerDetailInfo.", this.ContainerDetailInfo);
            this.SetParamObj(map, prefix + "ImageDetailInfo.", this.ImageDetailInfo);
            this.SetParamObj(map, prefix + "HostDetailInfo.", this.HostDetailInfo);
            this.SetParamObj(map, prefix + "K8SDetailInfo.", this.K8SDetailInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

