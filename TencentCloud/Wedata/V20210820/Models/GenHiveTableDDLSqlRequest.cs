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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenHiveTableDDLSqlRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 目标数据库
        /// </summary>
        [JsonProperty("SinkDatabase")]
        public string SinkDatabase{ get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 元数据类型(MYSQL、ORACLE)
        /// </summary>
        [JsonProperty("MsType")]
        public string MsType{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 来源库
        /// </summary>
        [JsonProperty("SourceDatabase")]
        public string SourceDatabase{ get; set; }

        /// <summary>
        /// 来源表
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 目标表元数据类型(HIVE、GBASE)
        /// </summary>
        [JsonProperty("SinkType")]
        public string SinkType{ get; set; }

        /// <summary>
        /// schema名称
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SinkDatabase", this.SinkDatabase);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "MsType", this.MsType);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "SourceDatabase", this.SourceDatabase);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "SinkType", this.SinkType);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
        }
    }
}
