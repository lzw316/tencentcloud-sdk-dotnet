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

    public class IntegrationTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 同步类型1.解决方案(整库迁移),2.单表同步
        /// </summary>
        [JsonProperty("SyncType")]
        public long? SyncType{ get; set; }

        /// <summary>
        /// 201.实时,202.离线
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 任务所属工作流id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务调度id(oceanus or us等作业id)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTaskId")]
        public string ScheduleTaskId{ get; set; }

        /// <summary>
        /// 任务组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupId")]
        public string TaskGroupId{ get; set; }

        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 创建人uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 操作人uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorUin")]
        public string OperatorUin{ get; set; }

        /// <summary>
        /// owner uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 应用id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 任务状态1.初始化,2.操作中,3.运行中,4.暂停,5.任务停止中,6.停止,7.执行失败,8.已删除,9.已锁定,10.配置过期,11.提交中,12.提交成功,13.提交失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 节点列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nodes")]
        public IntegrationNodeInfo[] Nodes{ get; set; }

        /// <summary>
        /// 执行资源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorId")]
        public string ExecutorId{ get; set; }

        /// <summary>
        /// 任务配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        public RecordField[] Config{ get; set; }

        /// <summary>
        /// 任务扩展配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtConfig")]
        public RecordField[] ExtConfig{ get; set; }

        /// <summary>
        /// 任务执行context信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteContext")]
        public RecordField[] ExecuteContext{ get; set; }

        /// <summary>
        /// 节点映射
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mappings")]
        public IntegrationNodeMapping[] Mappings{ get; set; }

        /// <summary>
        /// 任务模式：1.画布模式，2.flink jar
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskMode")]
        public string TaskMode{ get; set; }

        /// <summary>
        /// 责任人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Incharge")]
        public string Incharge{ get; set; }

        /// <summary>
        /// 离线新增参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTaskAddEntity")]
        public OfflineTaskAddParam OfflineTaskAddEntity{ get; set; }

        /// <summary>
        /// group name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongManagerUrl")]
        public string InLongManagerUrl{ get; set; }

        /// <summary>
        /// stream id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongStreamId")]
        public string InLongStreamId{ get; set; }

        /// <summary>
        /// version
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongManagerVersion")]
        public string InLongManagerVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ScheduleTaskId", this.ScheduleTaskId);
            this.SetParamSimple(map, prefix + "TaskGroupId", this.TaskGroupId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "OperatorUin", this.OperatorUin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "ExecutorId", this.ExecutorId);
            this.SetParamArrayObj(map, prefix + "Config.", this.Config);
            this.SetParamArrayObj(map, prefix + "ExtConfig.", this.ExtConfig);
            this.SetParamArrayObj(map, prefix + "ExecuteContext.", this.ExecuteContext);
            this.SetParamArrayObj(map, prefix + "Mappings.", this.Mappings);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "Incharge", this.Incharge);
            this.SetParamObj(map, prefix + "OfflineTaskAddEntity.", this.OfflineTaskAddEntity);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "InLongManagerUrl", this.InLongManagerUrl);
            this.SetParamSimple(map, prefix + "InLongStreamId", this.InLongStreamId);
            this.SetParamSimple(map, prefix + "InLongManagerVersion", this.InLongManagerVersion);
        }
    }
}
