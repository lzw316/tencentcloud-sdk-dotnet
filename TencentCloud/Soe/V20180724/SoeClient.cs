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

namespace TencentCloud.Soe.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Soe.V20180724.Models;

   public class SoeClient : AbstractClient{

       private const string endpoint = "soe.tencentcloudapi.com";
       private const string version = "2018-07-24";
       private const string sdkVersion = "SDK_NET_3.0.1273";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SoeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SoeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 初始化发音评估过程，每一轮评估前进行调用。语音输入模式分为流式模式和非流式模式，流式模式支持数据分片传输，可以加快评估响应速度。评估模式分为词模式和句子模式，词模式会标注每个音节的详细信息；句子模式会有完整度和流利度的评估。
        /// </summary>
        /// <param name="req"><see cref="InitOralProcessRequest"/></param>
        /// <returns><see cref="InitOralProcessResponse"/></returns>
        public Task<InitOralProcessResponse> InitOralProcess(InitOralProcessRequest req)
        {
            return InternalRequestAsync<InitOralProcessResponse>(req, "InitOralProcess");
        }

        /// <summary>
        /// 初始化发音评估过程，每一轮评估前进行调用。语音输入模式分为流式模式和非流式模式，流式模式支持数据分片传输，可以加快评估响应速度。评估模式分为词模式和句子模式，词模式会标注每个音节的详细信息；句子模式会有完整度和流利度的评估。
        /// </summary>
        /// <param name="req"><see cref="InitOralProcessRequest"/></param>
        /// <returns><see cref="InitOralProcessResponse"/></returns>
        public InitOralProcessResponse InitOralProcessSync(InitOralProcessRequest req)
        {
            return InternalRequestAsync<InitOralProcessResponse>(req, "InitOralProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 指定主题关键词词汇评估，分析语音与关键词的切合程度，可指定多个关键词，支持中文英文同时评测。分片传输时，尽量保证纯异步调用，即不等待上一个分片的传输结果边录边传，这样可以尽可能早的提供音频数据。音频源目前仅支持16k采样率16bit单声道编码方式，如有不一致可能导致评估不准确或失败。
        /// </summary>
        /// <param name="req"><see cref="KeywordEvaluateRequest"/></param>
        /// <returns><see cref="KeywordEvaluateResponse"/></returns>
        public Task<KeywordEvaluateResponse> KeywordEvaluate(KeywordEvaluateRequest req)
        {
            return InternalRequestAsync<KeywordEvaluateResponse>(req, "KeywordEvaluate");
        }

        /// <summary>
        /// 指定主题关键词词汇评估，分析语音与关键词的切合程度，可指定多个关键词，支持中文英文同时评测。分片传输时，尽量保证纯异步调用，即不等待上一个分片的传输结果边录边传，这样可以尽可能早的提供音频数据。音频源目前仅支持16k采样率16bit单声道编码方式，如有不一致可能导致评估不准确或失败。
        /// </summary>
        /// <param name="req"><see cref="KeywordEvaluateRequest"/></param>
        /// <returns><see cref="KeywordEvaluateResponse"/></returns>
        public KeywordEvaluateResponse KeywordEvaluateSync(KeywordEvaluateRequest req)
        {
            return InternalRequestAsync<KeywordEvaluateResponse>(req, "KeywordEvaluate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口可用于中英文发音评测数据传输。在使用本接口时需要注意：传输音频数据，必须在完成发音评估初始化接口之后调用，且SessonId要与初始化接口保持一致。分片传输时，尽量保证SeqId顺序传输（请确认SeqId由1开始）。音频源目前仅支持16k采样率16bit单声道编码方式，如有不一致可能导致评估不准确或失败。
        /// </summary>
        /// <param name="req"><see cref="TransmitOralProcessRequest"/></param>
        /// <returns><see cref="TransmitOralProcessResponse"/></returns>
        public Task<TransmitOralProcessResponse> TransmitOralProcess(TransmitOralProcessRequest req)
        {
            return InternalRequestAsync<TransmitOralProcessResponse>(req, "TransmitOralProcess");
        }

        /// <summary>
        /// 本接口可用于中英文发音评测数据传输。在使用本接口时需要注意：传输音频数据，必须在完成发音评估初始化接口之后调用，且SessonId要与初始化接口保持一致。分片传输时，尽量保证SeqId顺序传输（请确认SeqId由1开始）。音频源目前仅支持16k采样率16bit单声道编码方式，如有不一致可能导致评估不准确或失败。
        /// </summary>
        /// <param name="req"><see cref="TransmitOralProcessRequest"/></param>
        /// <returns><see cref="TransmitOralProcessResponse"/></returns>
        public TransmitOralProcessResponse TransmitOralProcessSync(TransmitOralProcessRequest req)
        {
            return InternalRequestAsync<TransmitOralProcessResponse>(req, "TransmitOralProcess")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口可用于中英文发音评测。在使用本接口时需要注意：初始化并传输音频数据，分片传输时，尽量保证SeqId顺序传输（请确认SeqId由1开始）。音频源目前仅支持16k采样率16bit单声道编码方式，如有不一致可能导致评估不准确或失败。
        /// </summary>
        /// <param name="req"><see cref="TransmitOralProcessWithInitRequest"/></param>
        /// <returns><see cref="TransmitOralProcessWithInitResponse"/></returns>
        public Task<TransmitOralProcessWithInitResponse> TransmitOralProcessWithInit(TransmitOralProcessWithInitRequest req)
        {
            return InternalRequestAsync<TransmitOralProcessWithInitResponse>(req, "TransmitOralProcessWithInit");
        }

        /// <summary>
        /// 本接口可用于中英文发音评测。在使用本接口时需要注意：初始化并传输音频数据，分片传输时，尽量保证SeqId顺序传输（请确认SeqId由1开始）。音频源目前仅支持16k采样率16bit单声道编码方式，如有不一致可能导致评估不准确或失败。
        /// </summary>
        /// <param name="req"><see cref="TransmitOralProcessWithInitRequest"/></param>
        /// <returns><see cref="TransmitOralProcessWithInitResponse"/></returns>
        public TransmitOralProcessWithInitResponse TransmitOralProcessWithInitSync(TransmitOralProcessWithInitRequest req)
        {
            return InternalRequestAsync<TransmitOralProcessWithInitResponse>(req, "TransmitOralProcessWithInit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
