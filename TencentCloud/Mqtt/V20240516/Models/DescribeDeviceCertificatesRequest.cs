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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceCertificatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 支持搜索参数
        /// ClientId：客户端id，根据实际业务使用获取
        /// CaSn：所属的CA证书SN序列号 可以从 [查询集群CA证书列表](https://cloud.tencent.com/document/api/1778/116206) 或者实际业务使用获取
        /// DeviceCertificateSn：设备证书SN序列号 可从[查询设备证书详情](https://cloud.tencent.com/document/api/1778/113748) 获取
        /// DeviceCertificateCn：设备证书CN 可从[查询设备证书详情](https://cloud.tencent.com/document/api/1778/113748) 获取
        /// OrganizationalUnit：证书OU
        /// NotAfterEnd：过期时间小于等于指定时间的证书
        /// NotAfterStart：过期时间大于等于指定时间的证书
        /// Status：设备证书状态     ACTIVE（激活）； INACTIVE（未激活）REVOKED（吊销）；PENDING_ACTIVATION（注册待激活）
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分页limit，默认20，最大100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量，默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序规则
        ///     CREATE_TIME_DESC, 创建时间降序
        ///     CREATE_TIME_ASC,创建时间升序
        ///     UPDATE_TIME_DESC,更新时间降序
        ///     UPDATE_TIME_ASC,更新时间升序
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
        }
    }
}

