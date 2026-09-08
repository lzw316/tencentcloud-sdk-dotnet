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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteAclRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka集群实例Id，可通过<a href="https://cloud.tencent.com/document/product/597/40835">DescribeInstances</a>接口获取</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Acl资源类型，(2:TOPIC，3:GROUP，4:CLUSTER)</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// <p>资源名称，和resourceType相关，如当resourceType为TOPIC时，则该字段表示topic名称，当resourceType为GROUP时，该字段表示group名称，当resourceType为CLUSTER时，该字段可为空。</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>Acl操作方式</p><p>枚举值：</p><ul><li>2： ALL</li><li>3： READ</li><li>4： WRITE</li><li>5： CREATE</li><li>6： DELETE</li><li>7： ALTER</li><li>8： DESCRIBE</li><li>9： CLUSTER_ACTION</li><li>10： DESCRIBE_CONFIGS</li><li>11： ALTER_CONFIGS</li><li>12： IDEMPOTENT_WRITE</li></ul><p>合法取值与 ResourceType 相关，传入组合以外的值将返回参数错误。本参数必须与 PermissionType 同时传入</p><ul><li>ResourceType=2（TOPIC）：2、3、4、5、6、7、8、10、11</li><li>ResourceType=3（GROUP）：2、3、6、8</li><li>ResourceType=4（CLUSTER）：2、5、7、8、9、10、11、12</li></ul>
        /// </summary>
        [JsonProperty("Operation")]
        public long? Operation{ get; set; }

        /// <summary>
        /// <p>权限类型，当前ckafka支持ALLOW(相当于白名单)，其它用于后续兼容开源kafka的acl时使用</p><p>枚举值：</p><ul><li>2： DENY</li><li>3： ALLOW</li></ul><p>本参数必须与 Operation 同时传入</p>
        /// </summary>
        [JsonProperty("PermissionType")]
        public long? PermissionType{ get; set; }

        /// <summary>
        /// <p>默认为*，表示任何host都可以访问，当前ckafka不支持host为*，但是后面开源kafka的产品化会直接支持</p><p>删除时与 Principal、Operation、PermissionType 一起参与精确匹配</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>用户列表，默认为User:*，表示任何user都可以访问，当前用户只能是用户列表中包含的用户</p><p>删除时不校验该用户是否仍存在，允许清理已删除用户的残留策略；该参数与 Host、Operation、PermissionType 一起参与精确匹配</p>
        /// </summary>
        [JsonProperty("Principal")]
        public string Principal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "PermissionType", this.PermissionType);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Principal", this.Principal);
        }
    }
}

