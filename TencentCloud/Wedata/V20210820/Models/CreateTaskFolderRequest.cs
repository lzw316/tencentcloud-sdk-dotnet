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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskFolderRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 文件夹名称
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 父文件夹ID
        /// </summary>
        [JsonProperty("ParentFolderId")]
        public string ParentFolderId{ get; set; }

        /// <summary>
        /// 目录分类，该值必传，枚举值如下：
        /// ETL：数据集成
        /// EMR：EMR
        /// TBDS：TBDS
        /// DLC：DLC
        /// TDSQL：TDSQL
        /// TCHOUSE：TCHOUSE
        /// GENERAL：通用
        /// TI_ONE：TI-ONE机器学习
        /// ACROSS_WORKFLOWS：跨工作流
        /// </summary>
        [JsonProperty("TaskNodeType")]
        public string TaskNodeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "ParentFolderId", this.ParentFolderId);
            this.SetParamSimple(map, prefix + "TaskNodeType", this.TaskNodeType);
        }
    }
}

