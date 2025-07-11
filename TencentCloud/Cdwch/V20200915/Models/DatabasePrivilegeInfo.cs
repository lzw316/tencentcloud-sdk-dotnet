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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatabasePrivilegeInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 库表权限，SELECT、INSERT_ALL、ALTER、TRUNCATE、DROP_TABLE、CREATE_TABLE、DROP_DATABASE
        /// </summary>
        [JsonProperty("DatabasePrivileges")]
        public string[] DatabasePrivileges{ get; set; }

        /// <summary>
        /// 库下面的表权限
        /// </summary>
        [JsonProperty("TablePrivilegeList")]
        public TablePrivilegeInfo[] TablePrivilegeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamArraySimple(map, prefix + "DatabasePrivileges.", this.DatabasePrivileges);
            this.SetParamArrayObj(map, prefix + "TablePrivilegeList.", this.TablePrivilegeList);
        }
    }
}

