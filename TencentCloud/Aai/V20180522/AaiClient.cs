/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Aai.V20180522
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Aai.V20180522.Models;

   public class AaiClient : AbstractClient{

       private const string endpoint = "aai.tencentcloudapi.com";
       private const string version = "2018-05-22";
       private const string sdkVersion = "SDK_NET_3.0.1273";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 提供基于文本的基础聊天能力，可以让您的应用快速拥有具备深度语义理解的机器聊天功能。
        /// </summary>
        /// <param name="req"><see cref="ChatRequest"/></param>
        /// <returns><see cref="ChatResponse"/></returns>
        public Task<ChatResponse> Chat(ChatRequest req)
        {
            return InternalRequestAsync<ChatResponse>(req, "Chat");
        }

        /// <summary>
        /// 提供基于文本的基础聊天能力，可以让您的应用快速拥有具备深度语义理解的机器聊天功能。
        /// </summary>
        /// <param name="req"><see cref="ChatRequest"/></param>
        /// <returns><see cref="ChatResponse"/></returns>
        public ChatResponse ChatSync(ChatRequest req)
        {
            return InternalRequestAsync<ChatResponse>(req, "Chat")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 识别60s内的短语音，当音频放在请求body中传输时整个请求大小不能超过600KB，当音频以url方式传输时，音频时长不可超过60s。所有请求参数放在post的body中采用x-www-form-urlencoded（数据转换成一个字符串（name1=value1&name2=value2…）进行urlencode后）编码传输。现暂只支持中文普通话识别，支持识别8k(16k)的16bit的mp3或者wav音频。
        /// </summary>
        /// <param name="req"><see cref="SentenceRecognitionRequest"/></param>
        /// <returns><see cref="SentenceRecognitionResponse"/></returns>
        public Task<SentenceRecognitionResponse> SentenceRecognition(SentenceRecognitionRequest req)
        {
            return InternalRequestAsync<SentenceRecognitionResponse>(req, "SentenceRecognition");
        }

        /// <summary>
        /// 识别60s内的短语音，当音频放在请求body中传输时整个请求大小不能超过600KB，当音频以url方式传输时，音频时长不可超过60s。所有请求参数放在post的body中采用x-www-form-urlencoded（数据转换成一个字符串（name1=value1&name2=value2…）进行urlencode后）编码传输。现暂只支持中文普通话识别，支持识别8k(16k)的16bit的mp3或者wav音频。
        /// </summary>
        /// <param name="req"><see cref="SentenceRecognitionRequest"/></param>
        /// <returns><see cref="SentenceRecognitionResponse"/></returns>
        public SentenceRecognitionResponse SentenceRecognitionSync(SentenceRecognitionRequest req)
        {
            return InternalRequestAsync<SentenceRecognitionResponse>(req, "SentenceRecognition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 该接口是实时流式识别，可同时返回语音识别文本及翻译文本，当前仅支持中文和英文。该接口可配合同传windows客户端，提供会议现场同传服务。
        /// </summary>
        /// <param name="req"><see cref="SimultaneousInterpretingRequest"/></param>
        /// <returns><see cref="SimultaneousInterpretingResponse"/></returns>
        public Task<SimultaneousInterpretingResponse> SimultaneousInterpreting(SimultaneousInterpretingRequest req)
        {
            return InternalRequestAsync<SimultaneousInterpretingResponse>(req, "SimultaneousInterpreting");
        }

        /// <summary>
        /// 该接口是实时流式识别，可同时返回语音识别文本及翻译文本，当前仅支持中文和英文。该接口可配合同传windows客户端，提供会议现场同传服务。
        /// </summary>
        /// <param name="req"><see cref="SimultaneousInterpretingRequest"/></param>
        /// <returns><see cref="SimultaneousInterpretingResponse"/></returns>
        public SimultaneousInterpretingResponse SimultaneousInterpretingSync(SimultaneousInterpretingRequest req)
        {
            return InternalRequestAsync<SimultaneousInterpretingResponse>(req, "SimultaneousInterpreting")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 腾讯云语音合成技术（TTS）可以将任意文本转化为语音，实现让机器和应用张口说话。
        /// 腾讯TTS技术可以应用到很多场景，比如，移动APP语音播报新闻；智能设备语音提醒；依靠网上现有节目或少量录音，快速合成明星语音，降低邀约成本；支持车载导航语音合成的个性化语音播报。
        /// 内测期间免费使用。
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public Task<TextToVoiceResponse> TextToVoice(TextToVoiceRequest req)
        {
            return InternalRequestAsync<TextToVoiceResponse>(req, "TextToVoice");
        }

        /// <summary>
        /// 腾讯云语音合成技术（TTS）可以将任意文本转化为语音，实现让机器和应用张口说话。
        /// 腾讯TTS技术可以应用到很多场景，比如，移动APP语音播报新闻；智能设备语音提醒；依靠网上现有节目或少量录音，快速合成明星语音，降低邀约成本；支持车载导航语音合成的个性化语音播报。
        /// 内测期间免费使用。
        /// </summary>
        /// <param name="req"><see cref="TextToVoiceRequest"/></param>
        /// <returns><see cref="TextToVoiceResponse"/></returns>
        public TextToVoiceResponse TextToVoiceSync(TextToVoiceRequest req)
        {
            return InternalRequestAsync<TextToVoiceResponse>(req, "TextToVoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
