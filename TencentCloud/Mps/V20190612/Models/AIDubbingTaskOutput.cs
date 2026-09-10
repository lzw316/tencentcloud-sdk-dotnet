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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIDubbingTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>基于画面提取的字幕文件路径。</p>
        /// </summary>
        [JsonProperty("OriginSubtitlePath")]
        public string OriginSubtitlePath{ get; set; }

        /// <summary>
        /// <p>基于画面提取的字幕翻译文件路径。</p>
        /// </summary>
        [JsonProperty("TranslateSubtitlePath")]
        public string TranslateSubtitlePath{ get; set; }

        /// <summary>
        /// <p>音色克隆后的视频文件地址</p>
        /// </summary>
        [JsonProperty("VoiceClonedVideo")]
        public string VoiceClonedVideo{ get; set; }

        /// <summary>
        /// <p>音色克隆的标注文件地址</p>
        /// </summary>
        [JsonProperty("VoiceClonedMarkFile")]
        public string VoiceClonedMarkFile{ get; set; }

        /// <summary>
        /// <p>视频输出路径。</p>
        /// </summary>
        [JsonProperty("VideoPath")]
        public string VideoPath{ get; set; }

        /// <summary>
        /// <p>基于画面提取的字幕文件FileId。</p>
        /// </summary>
        [JsonProperty("OriginSubtitleFileId")]
        public string OriginSubtitleFileId{ get; set; }

        /// <summary>
        /// <p>基于画面提取的字幕翻译文件FileId    。</p>
        /// </summary>
        [JsonProperty("TranslateSubtitleFileId")]
        public string TranslateSubtitleFileId{ get; set; }

        /// <summary>
        /// <p>标记文件路径。</p>
        /// </summary>
        [JsonProperty("SpeakerPath")]
        public string SpeakerPath{ get; set; }

        /// <summary>
        /// <p>标记文件Fileid。</p>
        /// </summary>
        [JsonProperty("SpeakerFileId")]
        public string SpeakerFileId{ get; set; }

        /// <summary>
        /// <p>擦除视频输出FileId。</p>
        /// </summary>
        [JsonProperty("EraseVideoFileId")]
        public string EraseVideoFileId{ get; set; }

        /// <summary>
        /// <p>擦除视频输出路径。</p>
        /// </summary>
        [JsonProperty("EraseVideoPath")]
        public string EraseVideoPath{ get; set; }

        /// <summary>
        /// <p>译文配音音频文件路径。</p>
        /// </summary>
        [JsonProperty("DstAudioPath")]
        public string DstAudioPath{ get; set; }

        /// <summary>
        /// <p>译文配音音频文件FileId。</p>
        /// </summary>
        [JsonProperty("DstAudioFileId")]
        public string DstAudioFileId{ get; set; }

        /// <summary>
        /// <p>音色克隆编辑信息</p><p>用于音色克隆二次修改的编辑信息</p>
        /// </summary>
        [JsonProperty("DubbingEditInfoUrl")]
        public string DubbingEditInfoUrl{ get; set; }

        /// <summary>
        /// <p>擦除的字幕位置。<strong>注意</strong>：仅对字幕提取且开启返回字幕位置时有效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubtitlePos")]
        public SubtitlePosition SubtitlePos{ get; set; }

        /// <summary>
        /// <p>AI配音任务输出文件的存储位置。</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginSubtitlePath", this.OriginSubtitlePath);
            this.SetParamSimple(map, prefix + "TranslateSubtitlePath", this.TranslateSubtitlePath);
            this.SetParamSimple(map, prefix + "VoiceClonedVideo", this.VoiceClonedVideo);
            this.SetParamSimple(map, prefix + "VoiceClonedMarkFile", this.VoiceClonedMarkFile);
            this.SetParamSimple(map, prefix + "VideoPath", this.VideoPath);
            this.SetParamSimple(map, prefix + "OriginSubtitleFileId", this.OriginSubtitleFileId);
            this.SetParamSimple(map, prefix + "TranslateSubtitleFileId", this.TranslateSubtitleFileId);
            this.SetParamSimple(map, prefix + "SpeakerPath", this.SpeakerPath);
            this.SetParamSimple(map, prefix + "SpeakerFileId", this.SpeakerFileId);
            this.SetParamSimple(map, prefix + "EraseVideoFileId", this.EraseVideoFileId);
            this.SetParamSimple(map, prefix + "EraseVideoPath", this.EraseVideoPath);
            this.SetParamSimple(map, prefix + "DstAudioPath", this.DstAudioPath);
            this.SetParamSimple(map, prefix + "DstAudioFileId", this.DstAudioFileId);
            this.SetParamSimple(map, prefix + "DubbingEditInfoUrl", this.DubbingEditInfoUrl);
            this.SetParamObj(map, prefix + "SubtitlePos.", this.SubtitlePos);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
        }
    }
}

