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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoScalingGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组名称，在您账号中必须唯一。名称仅支持中文、英文、数字、下划线、分隔符"-"、小数点，最大长度不能超55个字节。
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// 启动配置ID。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/config) 或调用接口 [DescribeLaunchConfigurations](https://cloud.tencent.com/document/api/377/20445) ，取返回信息中的 LaunchConfigurationId 获取启动配置ID。
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 最大实例数，取值范围为 [0,2000]，同时需满足 MaxSize >= DesiredCapacity >= MinSize 。
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 最小实例数，取值范围为 [0,2000]，同时需满足 MaxSize >= DesiredCapacity >= MinSize 。
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// 私有网络ID。有效的VpcId可通过登录[控制台](https://console.cloud.tencent.com/vpc/vpc)查询；也可以调用接口 [DescribeVpc](https://cloud.tencent.com/document/api/215/15778) ，从接口返回中的VpcId字段获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 默认冷却时间，单位秒，默认值为300。取值范围为 [0,3600]。
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public ulong? DefaultCooldown{ get; set; }

        /// <summary>
        /// 期望实例数，取值范围 [0,2000]，默认值等于当前 MinSize，同时需满足 MaxSize >= DesiredCapacity >= MinSize 。
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// 传统负载均衡器ID列表，目前长度上限为20，LoadBalancerIds 和 ForwardLoadBalancers 二者同时最多只能指定一个。可以通过 [DescribeLoadBalancers](https://cloud.tencent.com/document/product/214/30685) 接口获取。
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// 伸缩组内实例所属项目ID。默认值为0，表示使用默认项目。该参数可以通过调用 [DescribeProject](https://cloud.tencent.com/document/api/651/78725) 的返回值中的 projectId 字段来获取。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 负载均衡器列表，目前长度上限为100，LoadBalancerIds 和 ForwardLoadBalancers 二者同时最多只能指定一个
        /// </summary>
        [JsonProperty("ForwardLoadBalancers")]
        public ForwardLoadBalancer[] ForwardLoadBalancers{ get; set; }

        /// <summary>
        /// 子网ID列表，VPC场景下必须指定子网。多个子网以填写顺序为优先级，依次进行尝试，直至可以成功创建实例。有效的私有网络子网ID可通过登录[控制台](https://console.cloud.tencent.com/vpc/subnet)查询；也可以调用接口 [DescribeSubnets](https://cloud.tencent.com/document/product/215/15784) ，从接口返回中的SubnetId字段获取。
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 销毁策略，目前长度上限为1。取值包括 OLDEST_INSTANCE 和 NEWEST_INSTANCE，默认取值为 OLDEST_INSTANCE。
        /// <li> OLDEST_INSTANCE 优先销毁伸缩组中最旧的实例。</li>
        /// <li> NEWEST_INSTANCE，优先销毁伸缩组中最新的实例。</li>
        /// </summary>
        [JsonProperty("TerminationPolicies")]
        public string[] TerminationPolicies{ get; set; }

        /// <summary>
        /// 可用区列表，基础网络场景下必须指定可用区。多个可用区以填写顺序为优先级，依次进行尝试，直至可以成功创建实例。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 重试策略，取值包括 IMMEDIATE_RETRY、 INCREMENTAL_INTERVALS、NO_RETRY，默认取值为 IMMEDIATE_RETRY。部分成功的伸缩活动判定为一次失败活动。
        /// <li> IMMEDIATE_RETRY，立即重试，在较短时间内快速重试，连续失败超过一定次数（5次）后不再重试。</li> 
        /// <li> INCREMENTAL_INTERVALS，间隔递增重试，随着连续失败次数的增加，重试间隔逐渐增大。前 10 次重试间隔与立即重试模式相同，后续逐步递增至 10 分钟、30 分钟、60 分钟、一天。</li> 
        /// <li> NO_RETRY，不进行重试，直到再次收到用户调用或者告警信息后才会重试。</li> 
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// 可用区校验策略，取值包括 ALL 和 ANY，默认取值为ANY。
        /// <li> ALL，所有可用区（Zone）或子网（SubnetId）都可用则通过校验，否则校验报错。</li>
        /// <li> ANY，存在任何一个可用区（Zone）或子网（SubnetId）可用则通过校验，否则校验报错。</li>
        /// 
        /// 可用区或子网不可用的常见原因包括该可用区CVM实例类型售罄、该可用区CBS云盘售罄、该可用区配额不足、该子网IP不足等。
        /// 如果 Zones/SubnetIds 中可用区或者子网不存在，则无论 ZonesCheckPolicy 采用何种取值，都会校验报错。
        /// </summary>
        [JsonProperty("ZonesCheckPolicy")]
        public string ZonesCheckPolicy{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以支持绑定标签到伸缩组。同时绑定标签到相应的资源实例。每个伸缩组最多支持30个标签。可通过调用接口 [GetTags](https://cloud.tencent.com/document/product/651/72275) ，根据回参获取已有的标签键值对信息。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 服务设置，包括云监控不健康替换等服务设置。
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// 实例具有IPv6地址数量的配置，取值包括0、1。默认值为 0，表示实例不分配 IPv6 地址。需使用支持 IPv6 的私有网络，需在子网中开启 IPv6 CIDR，其他使用限制可参考 [IPv6使用限制](https://cloud.tencent.com/document/product/1142/38369)。
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// 多可用区/子网策略，取值包括 PRIORITY 和 EQUALITY，默认为 PRIORITY。
        /// <li> PRIORITY，按照可用区/子网列表的顺序，作为优先级来尝试创建实例，如果优先级最高的可用区/子网可以创建成功，则总在该可用区/子网创建。</li>
        /// <li> EQUALITY：扩容出的实例会打散到多个可用区/子网，保证扩容后的各个可用区/子网实例数相对均衡。</li>
        /// 
        /// 与本策略相关的注意点：
        /// <li> 当伸缩组为基础网络时，本策略适用于多可用区；当伸缩组为VPC网络时，本策略适用于多子网，此时不再考虑可用区因素，例如四个子网ABCD，其中ABC处于可用区1，D处于可用区2，此时考虑子网ABCD进行排序，而不考虑可用区1、2。</li>
        /// <li> 本策略适用于多可用区/子网，不适用于启动配置的多机型。多机型按照优先级策略进行选择。</li>
        /// <li> 按照 PRIORITY 策略创建实例时，先保证多机型的策略，后保证多可用区/子网的策略。例如多机型A、B，多子网1、2、3，会按照A1、A2、A3、B1、B2、B3 进行尝试，如果A1售罄，会尝试A2（而非B1）。</li>
        /// </summary>
        [JsonProperty("MultiZoneSubnetPolicy")]
        public string MultiZoneSubnetPolicy{ get; set; }

        /// <summary>
        /// 伸缩组实例健康检查类型，取值如下：
        /// <li>CVM：根据实例网络状态判断实例是否处于不健康状态，不健康的网络状态即发生实例 PING 不可达事件，详细判断标准可参考[实例健康检查](https://cloud.tencent.com/document/product/377/8553)</li>
        /// <li>CLB：根据 CLB 的健康检查状态判断实例是否处于不健康状态，CLB健康检查原理可参考[健康检查](https://cloud.tencent.com/document/product/214/6097) </li>
        /// 如果选择了`CLB`类型，伸缩组将同时检查实例网络状态与CLB健康检查状态，如果出现实例网络状态不健康，实例将被标记为 UNHEALTHY 状态；如果出现 CLB 健康检查状态异常，实例将被标记为CLB_UNHEALTHY 状态，如果两个异常状态同时出现，实例`HealthStatus`字段将返回 UNHEALTHY|CLB_UNHEALTHY。默认值：CLB
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// CLB健康检查宽限期，当扩容的实例进入`IN_SERVICE`后，在宽限期时间范围内将不会被标记为不健康`CLB_UNHEALTHY`。<br>默认值：0。取值范围[0, 7200]，单位：秒。
        /// </summary>
        [JsonProperty("LoadBalancerHealthCheckGracePeriod")]
        public ulong? LoadBalancerHealthCheckGracePeriod{ get; set; }

        /// <summary>
        /// 实例分配策略，取值包括 LAUNCH_CONFIGURATION 和 SPOT_MIXED，默认取 LAUNCH_CONFIGURATION。
        /// <li> LAUNCH_CONFIGURATION，代表传统的按照启动配置模式。</li>
        /// <li> SPOT_MIXED，代表竞价混合模式。目前仅支持启动配置为按量计费模式时使用混合模式，混合模式下，伸缩组将根据设定扩容按量或竞价机型。使用混合模式时，关联的启动配置的计费类型不可被修改。</li>
        /// </summary>
        [JsonProperty("InstanceAllocationPolicy")]
        public string InstanceAllocationPolicy{ get; set; }

        /// <summary>
        /// 竞价混合模式下，各计费类型实例的分配策略。
        /// 仅当 InstanceAllocationPolicy 取 SPOT_MIXED 时可用。
        /// </summary>
        [JsonProperty("SpotMixedAllocationPolicy")]
        public SpotMixedAllocationPolicy SpotMixedAllocationPolicy{ get; set; }

        /// <summary>
        /// 容量重平衡功能，仅对伸缩组内的竞价实例有效。取值范围：
        /// <li> TRUE，开启该功能，当伸缩组内的竞价实例即将被竞价实例服务自动回收前，AS 主动发起竞价实例销毁流程，如果有配置过缩容 hook，则销毁前 hook 会生效。销毁流程启动后，AS 会异步开启一个扩容活动，用于补齐期望实例数。</li>
        /// <li> FALSE，不开启该功能，则 AS 等待竞价实例被销毁后才会去扩容补齐伸缩组期望实例数。</li>
        /// 默认取 FALSE。
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public bool? CapacityRebalance{ get; set; }

        /// <summary>
        /// 实例名称序号相关设置。若不指定该参数，则默认不开启。开启后为伸缩组内自动创建的实例名称添加递增的数字序号。
        /// </summary>
        [JsonProperty("InstanceNameIndexSettings")]
        public InstanceNameIndexSettings InstanceNameIndexSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancers.", this.ForwardLoadBalancers);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "TerminationPolicies.", this.TerminationPolicies);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ZonesCheckPolicy", this.ZonesCheckPolicy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamSimple(map, prefix + "MultiZoneSubnetPolicy", this.MultiZoneSubnetPolicy);
            this.SetParamSimple(map, prefix + "HealthCheckType", this.HealthCheckType);
            this.SetParamSimple(map, prefix + "LoadBalancerHealthCheckGracePeriod", this.LoadBalancerHealthCheckGracePeriod);
            this.SetParamSimple(map, prefix + "InstanceAllocationPolicy", this.InstanceAllocationPolicy);
            this.SetParamObj(map, prefix + "SpotMixedAllocationPolicy.", this.SpotMixedAllocationPolicy);
            this.SetParamSimple(map, prefix + "CapacityRebalance", this.CapacityRebalance);
            this.SetParamObj(map, prefix + "InstanceNameIndexSettings.", this.InstanceNameIndexSettings);
        }
    }
}

