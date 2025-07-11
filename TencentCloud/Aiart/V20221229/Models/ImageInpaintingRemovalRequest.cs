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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInpaintingRemovalRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入图 Base64 数据。
        /// Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// 图片限制：单边分辨率小于5000，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("InputImage")]
        public string InputImage{ get; set; }

        /// <summary>
        /// 输入图 Url。
        /// Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// 图片限制：单边分辨率小于5000，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// 消除区域 Mask 图 Base64 数据。
        /// Mask 为单通道灰度图，待消除部分呈白色区域，原图保持部分呈黑色区域。
        /// Mask 的 Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// 图片限制：Mask 分辨率需要和输入原图保持一致，转成 Base64 字符串后小于 6MB。
        /// </summary>
        [JsonProperty("Mask")]
        public string Mask{ get; set; }

        /// <summary>
        /// 消除区域 Mask 图 Url。
        /// Mask 为单通道灰度图，待消除部分呈白色区域，原图保持部分呈黑色区域。
        /// Mask 的 Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// 图片限制：Mask 分辨率需要和输入原图保持一致，转成 Base64 字符串后小于 6MB。
        /// </summary>
        [JsonProperty("MaskUrl")]
        public string MaskUrl{ get; set; }

        /// <summary>
        /// 返回图像方式（base64 或 url) ，二选一，默认为 base64。url 有效期为1小时。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 为生成结果图添加标识的开关，默认为1。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputImage", this.InputImage);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
            this.SetParamSimple(map, prefix + "MaskUrl", this.MaskUrl);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

