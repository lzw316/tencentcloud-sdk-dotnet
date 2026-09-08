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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>该字段用于返回创建音频审核任务后返回的任务ID（在Results参数中），用于标识需要查询任务详情的审核任务。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用音频审核接口时在Tasks参数内传入的数据ID参数，方便数据的辨别和管理。</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用音频审核接口时传入的BizType参数，方便数据的辨别和管理。</p>
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用音频审核接口时传入的TaskInput参数中的任务名称，方便任务的识别与管理。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>该字段用于返回所查询内容的任务状态。<br><br>取值：<strong>FINISH</strong>（任务已完成）、<strong>PENDING</strong> （任务等待中）、<strong>RUNNING</strong> （任务进行中）、<strong>ERROR</strong> （任务出错）、<strong>CANCELLED</strong> （任务已取消）。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>该字段用于返回调用音频审核接口时输入的音频审核类型，取值为：<strong>AUDIO</strong>（点播音频）和<strong>LIVE_AUDIO</strong>（直播音频），默认值为AUDIO。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>该字段用于返回基于恶意标签的后续操作建议。当您获取到判定结果后，返回值表示系统推荐的后续操作；建议您按照业务所需，对不同违规类型与建议值进行处理。<br>返回值：<strong>Block</strong>：建议屏蔽，<strong>Review</strong> ：建议人工复审，<strong>Pass</strong>：建议通过</p>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>该字段用于返回检测结果所对应的恶意标签。<br>返回值：<strong>Porn</strong>：色情，<strong>Abuse</strong>：谩骂，<strong>Ad</strong>：广告，<strong>Custom</strong>：自定义违规；以及其他令人反感、不安全或不适宜的内容类型。</p>
        /// </summary>
        [JsonProperty("Labels")]
        public TaskLabel[] Labels{ get; set; }

        /// <summary>
        /// <p>该字段用于返回审核服务的媒体内容信息，主要包括传入文件类型和访问地址。</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public InputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>该字段用于返回音频文件识别出的对应文本内容，最大支持<strong>前1000个字符</strong>。</p>
        /// </summary>
        [JsonProperty("AudioText")]
        public string AudioText{ get; set; }

        /// <summary>
        /// <p>该字段用于返回音频片段的审核结果，主要包括开始时间和音频审核的相应结果。<br>具体输出内容请参见AudioSegments及AudioResult数据结构的详细描述。</p>
        /// </summary>
        [JsonProperty("AudioSegments")]
        public AudioSegments[] AudioSegments{ get; set; }

        /// <summary>
        /// <p>当任务状态为Error时，该字段用于返回对应错误的类型；任务状态非Error时，默认返回为空。</p>
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>当任务状态为Error时，该字段用于返回对应错误的详细描述，任务状态非Error时默认返回为空。</p>
        /// </summary>
        [JsonProperty("ErrorDescription")]
        public string ErrorDescription{ get; set; }

        /// <summary>
        /// <p>该字段用于返回被查询任务创建的时间，格式采用 ISO 8601标准。</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>该字段用于返回被查询任务最后更新时间，格式采用 ISO 8601标准。</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>该字段用于返回检测结果所对应的标签。如果未命中恶意，返回Normal，如果命中恶意，则返回Labels中优先级最高的标签</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>媒体信息</p>
        /// </summary>
        [JsonProperty("MediaInfo")]
        public MediaInfo MediaInfo{ get; set; }

        /// <summary>
        /// <p>命中信息</p>
        /// </summary>
        [JsonProperty("HitSnippetInfos")]
        public HitSnippetInfos[] HitSnippetInfos{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "AudioText", this.AudioText);
            this.SetParamArrayObj(map, prefix + "AudioSegments.", this.AudioSegments);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "ErrorDescription", this.ErrorDescription);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamObj(map, prefix + "MediaInfo.", this.MediaInfo);
            this.SetParamArrayObj(map, prefix + "HitSnippetInfos.", this.HitSnippetInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

