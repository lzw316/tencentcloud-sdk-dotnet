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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FirmwareInfo : AbstractModel
    {
        
        /// <summary>
        /// 固件版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 固件MD5值
        /// </summary>
        [JsonProperty("Md5sum")]
        public string Md5sum{ get; set; }

        /// <summary>
        /// 固件创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 固件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 固件描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 固件升级模块
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// 创建者子 uin
        /// </summary>
        [JsonProperty("CreateUserId")]
        public long? CreateUserId{ get; set; }

        /// <summary>
        /// 创建者昵称
        /// </summary>
        [JsonProperty("CreatorNickName")]
        public string CreatorNickName{ get; set; }

        /// <summary>
        /// 固件用户自定义配置信息
        /// </summary>
        [JsonProperty("UserDefined")]
        public string UserDefined{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Md5sum", this.Md5sum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "CreateUserId", this.CreateUserId);
            this.SetParamSimple(map, prefix + "CreatorNickName", this.CreatorNickName);
            this.SetParamSimple(map, prefix + "UserDefined", this.UserDefined);
        }
    }
}

