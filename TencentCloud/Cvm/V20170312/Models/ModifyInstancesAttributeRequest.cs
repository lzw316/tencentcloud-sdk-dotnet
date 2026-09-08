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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstancesAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>一个或多个待操作的实例ID。可通过<a href="https://cloud.tencent.com/document/api/213/15728">DescribeInstances</a> API返回值中的<code>InstanceId</code>获取。每次请求允许操作的实例数量上限是100。</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>修改后实例名称。可任意命名，但不得超过60个字符。</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>提供给实例使用的用户数据，需要以 base64 方式编码，支持的最大数据大小为 16 KB。关于获取此参数的详细介绍，请参阅 <a href="https://cloud.tencent.com/document/product/213/17526">Windows</a> 和 <a href="https://cloud.tencent.com/document/product/213/17525">Linux</a> 启动时运行命令。</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>指定实例的修改后的安全组Id列表，子机将重新关联指定列表的安全组，原本关联的安全组会被解绑。</p>
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// <p>给实例绑定用户角色，传空值为解绑操作</p>
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// <p>修改后实例的主机名。<li>点号（.）和短横线（-）不能作为 HostName 的首尾字符，不能连续使用。</li><li>Windows 实例：主机名字符长度为[2, 15]，允许字母（不限制大小写）、数字和短横线（-）组成，不支持点号（.），不能全是数字。</li><li>其他类型（Linux 等）实例：主机名字符长度为[2, 60]，允许支持多个点号，点之间为一段，每段允许字母（不限制大小写）、数字和短横线（-）组成。</li>注意点：修改主机名后实例会立即重启，重启后新的主机名生效。</p>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>实例销毁保护标志，表示是否允许通过api接口删除实例。取值范围：<li>true：表示开启实例保护，不允许通过api接口删除实例</li><li>false：表示关闭实例保护，允许通过api接口删除实例</li>默认取值：false。</p>
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// <p>角色类别，与CamRoleName搭配使用，该值可从CAM <a href="https://cloud.tencent.com/document/product/598/36223"> DescribeRoleList </a>或<a href="https://cloud.tencent.com/document/product/598/36221"> GetRole </a>接口返回RoleType字段获取，当前只接受user、system和service_linked三种类别。<br>举例：一般CamRoleName中包含“LinkedRoleIn”（如TKE_QCSLinkedRoleInPrometheusService）时，DescribeRoleList和GetRole返回的RoleType为service_linked，则本参数也需要传递service_linked。<br>该参数默认值为user，若CameRoleName为非service_linked类型，本参数可不传递。</p>
        /// </summary>
        [JsonProperty("CamRoleType")]
        public string CamRoleType{ get; set; }

        /// <summary>
        /// <p>修改实例主机名是否自动重启实例，不传默认自动重启。</p><ul><li>true: 修改主机名，并自动重启实例；</li><li>false: 修改主机名，不自动重启实例，需要手动重启使新主机名生效。<br>注意点：本参数仅对修改主机名生效。</li></ul>
        /// </summary>
        [JsonProperty("AutoReboot")]
        public bool? AutoReboot{ get; set; }

        /// <summary>
        /// <p>实例是否开启巨型帧，取值范围：<br></p><ul><li>true：表示实例开启巨型帧，只有支持巨型帧的机型可设置为true。</li><li>false：表示实例关闭巨型帧，只有支持巨型帧的机型可设置为false。<br><br>支持巨型帧的实例规格： <a href="https://cloud.tencent.com/document/product/213/11518">实例规格</a></li></ul>
        /// </summary>
        [JsonProperty("EnableJumboFrame")]
        public bool? EnableJumboFrame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
            this.SetParamSimple(map, prefix + "CamRoleType", this.CamRoleType);
            this.SetParamSimple(map, prefix + "AutoReboot", this.AutoReboot);
            this.SetParamSimple(map, prefix + "EnableJumboFrame", this.EnableJumboFrame);
        }
    }
}

