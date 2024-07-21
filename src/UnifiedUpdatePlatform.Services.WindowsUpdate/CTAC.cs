/*
 * Copyright (c) Gustave Monce and Contributors
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System;

namespace UnifiedUpdatePlatform.Services.WindowsUpdate
{
    public enum MachineType : ushort
    {
        unknown = 0x0,
        x86 = 0x14c,
        r4000 = 0x166,
        wcemipsv2 = 0x169,
        axp = 0x184,
        sh3 = 0x1a2,
        sh3dsp = 0x1a3,
        sh4 = 0x1a6,
        sh5 = 0x1a8,
        arm = 0x1c0,
        thumb = 0x1c2,
        woa = 0x1c4,
        am33 = 0x1d3,
        powerpc = 0x1f0,
        powerpcfp = 0x1f1,
        ia64 = 0x200,
        mips16 = 0x266,
        mipsfpu = 0x366,
        mipsfpu16 = 0x466,
        ebc = 0xebc,
        amd64 = 0x8664,
        m32r = 0x9041,
        arm64 = 0xaa64,
    }

    public enum OSSkuId
    {
        Undefined = 0x00000000,    // 0
        Ultimate = 0x00000001,    // 1
        HomeBasic = 0x00000002,    // 2
        HomePremium = 0x00000003,    // 3
        Enterprise = 0x00000004,    // 4
        HomeBasicN = 0x00000005,    // 5
        Business = 0x00000006,    // 6
        ServerStandard = 0x00000007,    // 7
        ServerDatacenter = 0x00000008,    // 8
        ServerSmallBusiness = 0x00000009,    // 9
        ServerEnterprise = 0x0000000A,    // 10
        Starter = 0x0000000B,    // 11
        ServerDatacenterCore = 0x0000000C,    // 12
        ServerStandardCore = 0x0000000D,    // 13
        ServerEnterpriseCore = 0x0000000E,    // 14
        ServerEnterpriseIA64 = 0x0000000F,    // 15
        BusinessN = 0x00000010,    // 16
        ServerWeb = 0x00000011,    // 17
        ServerCluster = 0x00000012,    // 18
        ServerHome = 0x00000013,    // 19
        ServerStorageExpress = 0x00000014,    // 20
        ServerStorageStandard = 0x00000015,    // 21
        ServerStorageWorkgroup = 0x00000016,    // 22
        ServerStorageEnterprise = 0x00000017,    // 23
        ServerForSmallBusiness = 0x00000018,    // 24
        ServerSmallBusinessPremium = 0x00000019,    // 25
        HomePremiumN = 0x0000001A,    // 26
        EnterpriseN = 0x0000001B,    // 27
        UltimateN = 0x0000001C,    // 28
        ServerWebCore = 0x0000001D,    // 29
        ServerMediumBusinessManagement = 0x0000001E,    // 30
        ServerMediumBusinessSecurity = 0x0000001F,    // 31
        ServerMediumBusinessMessaging = 0x00000020,    // 32
        ServerFoundation = 0x00000021,    // 33
        ServerHomePremium = 0x00000022,    // 34
        ServerForSmallBusinessV = 0x00000023,    // 35
        ServerStandardV = 0x00000024,    // 36
        ServerDatacenterV = 0x00000025,    // 37
        ServerEnterpriseV = 0x00000026,    // 38
        ServerDatacenterCoreV = 0x00000027,    // 39
        ServerStandardCoreV = 0x00000028,    // 40
        EnterpriseServerCoreV = 0x00000029,    // 41
        ServerHyperCore = 0x0000002A,    // 42
        ServerStorageExpressCore = 0x0000002B,    // 43
        ServerStorageStandardCore = 0x0000002C,    // 44
        ServerStorageWorkgroupCore = 0x0000002D,    // 45
        ServerStorageEnterpriseCore = 0x0000002E,    // 46
        StarterN = 0x0000002F,    // 47
        Professional = 0x00000030,    // 48
        ProfessionalN = 0x00000031,    // 49
        ServerSolution = 0x00000032,    // 50
        ServerSBSolution = 0x00000033,    // 51
        ServerStandardSolution = 0x00000034,    // 52
        ServerStandardSolutionCore = 0x00000035,    // 53
        ServerSBSolutionEmbedded = 0x00000036,    // 54
        ServerForSmallBusinessEmbedded = 0x00000037,    // 55
        ServerEmbeddedSolution = 0x00000038,    // 56
        ServerEmbeddedSolutionCore = 0x00000039,    // 57
        ProfessionalEmbedded = 0x0000003A,    // 58
        ServerEssentialBusinessMgmt = 0x0000003B,    // 59
        ServerEssentialBusinessAddl = 0x0000003C,    // 60
        ServerEssentialBusinessMgmtSvc = 0x0000003D,    // 61
        ServerEssentialBusinessAddlSvc = 0x0000003E,    // 62
        ServerSmallBusinessPremiumCore = 0x0000003F,    // 63
        ServerClusterV = 0x00000040,    // 64
        Embedded = 0x00000041,    // 65
        StarterE = 0x00000042,    // 66
        HomeBasicE = 0x00000043,    // 67
        HomePremiumE = 0x00000044,    // 68
        ProfessionalE = 0x00000045,    // 69
        EnterpriseE = 0x00000046,    // 70
        UltimateE = 0x00000047,    // 71
        EnterpriseEval = 0x00000048,    // 72
        Unknown = 0x00000049,    // 73
        Prerelease = 0x0000004A,    // 74
        Unknown4B = 0x0000004B,    // 75
        ServerMultipointStandard = 0x0000004C,    // 76
        ServerMultipointPremium = 0x0000004D,    // 77
        Unknown4E = 0x0000004E,    // 78
        ServerStandardEval = 0x0000004F,    // 79
        ServerDatacenterEval = 0x00000050,    // 80
        PrereleaseARM = 0x00000051,    // 81
        PrereleaseN = 0x00000052,    // 82
        Unknown53 = 0x00000053,    // 83
        EnterpriseNEval = 0x00000054,    // 84
        EmbeddedAutomotive = 0x00000055,    // 85
        EmbeddedIndustryA = 0x00000056,    // 86
        ThinPC = 0x00000057,    // 87
        EmbeddedA = 0x00000058,    // 88
        EmbeddedIndustry = 0x00000059,    // 89
        EmbeddedE = 0x0000005A,    // 90
        EmbeddedIndustryE = 0x0000005B,    // 91
        EmbeddedIndustryAE = 0x0000005C,    // 92
        ProfessionalPlus = 0x0000005D,    // 93
        Unknown5E = 0x0000005E,    // 94
        ServerStorageWorkgroupEval = 0x0000005F,    // 95
        ServerStorageStandardEval = 0x00000060,    // 96
        CoreARM = 0x00000061,    // 97
        CoreN = 0x00000062,    // 98
        CoreCountrySpecific = 0x00000063,    // 99
        CoreSingleLanguage = 0x00000064,    // 100
        Core = 0x00000065,    // 101
        Unknown66 = 0x00000066,    // 102
        ProfessionalWMC = 0x00000067,    // 103
        MobileCore = 0x00000068,    // 104
        EmbeddedIndustryEval = 0x00000069,    // 105
        EmbeddedIndustryEEval = 0x0000006A,    // 106
        EmbeddedEval = 0x0000006B,    // 107
        EmbeddedEEval = 0x0000006C,    // 108
        ServerNano = 0x0000006D,    // 109
        ServerCloudStorage = 0x0000006E,    // 110
        CoreConnected = 0x0000006F,    // 111
        ProfessionalStudent = 0x00000070,    // 112
        CoreConnectedN = 0x00000071,    // 113
        ProfessionalStudentN = 0x00000072,    // 114
        CoreConnectedSingleLanguage = 0x00000073,    // 115
        CoreConnectedCountrySpecific = 0x00000074,    // 116
        ConnectedCar = 0x00000075,    // 117
        IndustryHandheld = 0x00000076,    // 118
        PPIPro = 0x00000077,    // 119
        ServerARM64 = 0x00000078,    // 120
        Education = 0x00000079,    // 121
        EducationN = 0x0000007A,    // 122
        IoTUAP = 0x0000007B,    // 123
        ServerCloudHostInfrastructure = 0x0000007C,    // 124
        EnterpriseS = 0x0000007D,    // 125
        EnterpriseSN = 0x0000007E,    // 126
        ProfessionalS = 0x0000007F,    // 127
        ProfessionalSN = 0x00000080,    // 128
        EnterpriseSEval = 0x00000081,    // 129
        EnterpriseSNEval = 0x00000082,    // 130
        IoTUAPCommercial = 0x00000083,    // 131
        Unknown84 = 0x00000084,    // 132
        MobileEnterprise = 0x00000085,    // 133
        Unknown86 = 0x00000086,    // 134
        Holographic = 0x00000087,    // 135
        HolographicBusiness = 0x00000088,    // 136
        Unknown89 = 0x00000089,    // 137
        ProfessionalSingleLanguage = 0x0000008A,    // 138
        ProfessionalCountrySpecific = 0x0000008B,    // 139
        EnterpriseSubscription = 0x0000008C,    // 140
        EnterpriseSubscriptionN = 0x0000008D,    // 141
        Unknown8E = 0x0000008E,    // 142
        ServerDatacenterNano = 0x0000008F,    // 143
        ServerStandardNano = 0x00000090,    // 144
        ServerDatacenterACor = 0x00000091,    // 145
        ServerStandardACor = 0x00000092,    // 146
        ServerDatacenterWSCore = 0x00000093,    // 147
        ServerStandardWSCore = 0x00000094,    // 148
        UtilityVM = 0x00000095,    // 149
        Unknown96 = 0x00000096,    // 150
        Unknown97 = 0x00000097,    // 151
        Unknown98 = 0x00000098,    // 152
        Unknown99 = 0x00000099,    // 153
        Unknown9A = 0x0000009A,    // 154
        Unknown9B = 0x0000009B,    // 155
        Unknown9C = 0x0000009C,    // 156
        Unknown9D = 0x0000009D,    // 157
        Unknown9E = 0x0000009E,    // 158
        ServerDatacenterEvalCore = 0x0000009F,    // 159
        ServerStandardEvalCore = 0x000000A0,    // 160
        ProfessionalWorkstation = 0x000000A1,    // 161
        ProfessionalWorkstationN = 0x000000A2,    // 162
        UnknownA3 = 0x000000A3,    // 163
        ProfessionalEducation = 0x000000A4,    // 164
        ProfessionalEducationN = 0x000000A5,    // 165
        UnknownA6 = 0x000000A6,    // 166
        UnknownA7 = 0x000000A7,    // 167
        ServerAzureCore = 0x000000A8,    // 168
        ServerAzureNano = 0x000000A9,    // 169
        UnknownAA = 0x000000AA,    // 170
        EnterpriseG = 0x000000AB,    // 171
        EnterpriseGN = 0x000000AC,    // 172
        Business2 = 0x000000AD,    // 173
        Business2N = 0x000000AE,    // 174
        ServerRdsh = 0x000000AF,    // 175
        ServerRdshCore = 0x000000B0,    // 176
        UnknownB1 = 0x000000B1,    // 177
        Cloud = 0x000000B2,    // 178
        CloudN = 0x000000B3,    // 179
        HubOS = 0x000000B4,    // 180
        UnknownB5 = 0x000000B5,    // 181
        OneCoreUpdateOS = 0x000000B6,    // 182
        CloudE = 0x000000B7,    // 183
        Andromeda = 0x000000B8,    // 184
        IoTOS = 0x000000B9,    // 185
        CloudEN = 0x000000BA,    // 186
        IoTEdgeOS = 0x000000BB,    // 187
        IoTEnterprise = 0x000000BC,    // 188
        Lite = 0x000000BD,    // 189
        UnknownBE = 0x000000BE,    // 190
        IoTEnterpriseS = 0x000000BF,    // 191
        XboxSystemOS = 0x000000C0,    // 192
        XboxNativeOS = 0x000000C1,    // 193
        XboxGameOS = 0x000000C2,    // 194
        XboxEraOS = 0x000000C3,    // 195
        XboxDurangoHostOS = 0x000000C4,    // 196
        XboxScarlettHostOS = 0x000000C5,    // 197
        XboxKeystone = 0x000000C6,    // 198
        AzureServerCloudHost = 0x000000C7,    // 199
        AzureServerCloudMOS = 0x000000C8,    // 200
        UnknownC9 = 0x000000C9,    // 201
        CloudEditonN = 0x000000CA,    // 202
        CloudEdition = 0x000000CB,    // 203
        Validation = 0x000000CC,    // 204
        IoTEnterpriseSK = 0x000000CD,    // 205
        IoTEnterpriseK = 0x000000CE,    // 206
        IoTEnterpriseSEval = 0x000000CF,    // 207
        UnknownD0 = 0x000000D0,    // 208
        UnknownD1 = 0x000000D1,    // 209
        WNC = 0x000000D2,    // 210
        UnknownD3 = 0x000000D2,    // 211
        UnknownD4 = 0x000000D4,    // 212
        UnknownD5 = 0x000000D5,    // 213
        UnknownD6 = 0x000000D6,    // 214
        UnknownD7 = 0x000000D7,    // 215
        UnknownD8 = 0x000000D8,    // 216
        UnknownD9 = 0x000000D9,    // 217
        UnknownDA = 0x000000DA,    // 218
        UnknownDB = 0x000000DB,    // 219
        UnknownDC = 0x000000DC,    // 220
        UnknownDD = 0x000000DD,    // 221
        UnknownDE = 0x000000DE,    // 222
        UnknownDF = 0x000000DF,    // 223
        UnknownE0 = 0x000000E0,    // 224
        UnknownE1 = 0x000000E1,    // 225
        UnknownE2 = 0x000000E2,    // 226
        UnknownE3 = 0x000000E3,    // 227
        UnknownE4 = 0x000000E4,    // 228
        UnknownE5 = 0x000000E5,    // 229
        UnknownE6 = 0x000000E6,    // 230
        UnknownE7 = 0x000000E7,    // 231
        UnknownE8 = 0x000000E8,    // 232
        UnknownE9 = 0x000000E9,    // 233
        UnknownEA = 0x000000EA,    // 234
        UnknownEB = 0x000000EB,    // 235
        UnknownEC = 0x000000EC,    // 236
        UnknownED = 0x000000ED,    // 237
        UnknownEE = 0x000000EE,    // 238
        UnknownEF = 0x000000EF,    // 239
        UnknownF0 = 0x000000F0,    // 240
        UnknownF1 = 0x000000F1,    // 241
        UnknownF2 = 0x000000F2,    // 242
        UnknownF3 = 0x000000F3,    // 243
        UnknownF4 = 0x000000F4,    // 244
        UnknownF5 = 0x000000F5,    // 245
        UnknownF6 = 0x000000F6,    // 246
        UnknownF7 = 0x000000F7,    // 247
        UnknownF8 = 0x000000F8,    // 248
        UnknownF9 = 0x000000F9,    // 249
        UnknownFA = 0x000000FA,    // 250
        UnknownFB = 0x000000FB,    // 251
        UnknownFC = 0x000000FC,    // 252
        UnknownFD = 0x000000FD,    // 253
        UnknownFE = 0x000000FE,    // 254
        UnknownFF = 0x000000FF,    // 255
        Unknown100 = 0x00000100,   // 256
        Unknown101 = 0x00000101,   // 257
        Unknown102 = 0x00000102,   // 258
        Unknown103 = 0x00000103,   // 259
        Unknown104 = 0x00000104,   // 260
        Unknown105 = 0x00000105,   // 261
        Unknown106 = 0x00000106,   // 262
        Unknown107 = 0x00000107,   // 263
        Unknown108 = 0x00000108,   // 264
        Unknown109 = 0x00000109,   // 265
        Unknown10A = 0x0000010A,   // 266
        Unknown10B = 0x0000010B,   // 267
        Unknown10C = 0x0000010C,   // 268
        Unknown10D = 0x0000010D,   // 269
        Unknown10E = 0x0000010E,   // 270
        Unknown10F = 0x0000010F,   // 271
        Unknown110 = 0x00000110,   // 272
        Unknown111 = 0x00000111,   // 273
        Unknown112 = 0x00000112,   // 274
        Unknown113 = 0x00000113,   // 275
        Unknown114 = 0x00000114,   // 276
        Unknown115 = 0x00000115,   // 277
        Unknown116 = 0x00000116,   // 278
        Unknown117 = 0x00000117,   // 279
        Unknown118 = 0x00000118,   // 280
        Unknown119 = 0x00000119,   // 281
        Unknown11A = 0x0000011A,   // 282
        Unknown11B = 0x0000011B,   // 283
        Unknown11C = 0x0000011C,   // 284
        Unknown11D = 0x0000011D,   // 285
        Unknown11E = 0x0000011E,   // 286
        Unknown11F = 0x0000011F,   // 287
        Unknown120 = 0x00000120,   // 288
        Unknown121 = 0x00000121,   // 289
        Unknown122 = 0x00000122,   // 290
        Unknown123 = 0x00000123,   // 291
        Unknown124 = 0x00000124,   // 292
        Unknown125 = 0x00000125,   // 293
        Unknown126 = 0x00000126,   // 294
        Unknown127 = 0x00000127,   // 295
        Unknown128 = 0x00000128,   // 296
        Unknown129 = 0x00000129,   // 297
        Unknown12A = 0x0000012A,   // 298
        Unknown12B = 0x0000012B,   // 299
        Unknown12C = 0x0000012C,   // 300
        Unknown12D = 0x0000012D,   // 301
        Unknown12E = 0x0000012E,   // 302
        Unknown12F = 0x0000012F,   // 303
        Unknown130 = 0x00000130,   // 304
        Unknown131 = 0x00000131,   // 305
        Unknown132 = 0x00000132,   // 306
        Unknown133 = 0x00000133,   // 307
        Unknown134 = 0x00000134,   // 308
        Unknown135 = 0x00000135,   // 309
        Unknown136 = 0x00000136,   // 310
        Unknown137 = 0x00000137,   // 311
        Unknown138 = 0x00000138,   // 312
        Unknown139 = 0x00000139,   // 313
        Unknown13A = 0x0000013A,   // 314
        Unknown13B = 0x0000013B,   // 315
        Unknown13C = 0x0000013C,   // 316
        Unknown13D = 0x0000013D,   // 317
        Unknown13E = 0x0000013E,   // 318
        Unknown13F = 0x0000013F,   // 319
        Unknown140 = 0x00000140,   // 320
        Unknown141 = 0x00000141,   // 321
        Unknown142 = 0x00000142,   // 322
        Unknown143 = 0x00000143,   // 323
        Unknown144 = 0x00000144,   // 324
        Unknown145 = 0x00000145,   // 325
        Unknown146 = 0x00000146,   // 326
        Unknown147 = 0x00000147,   // 327
        Unknown148 = 0x00000148,   // 328
        Unknown149 = 0x00000149,   // 329
        Unknown14A = 0x0000014A,   // 330
        Unknown14B = 0x0000014B,   // 331
        Unknown14C = 0x0000014C,   // 332
        Unknown14D = 0x0000014D,   // 333
        Unknown14E = 0x0000014E,   // 334
        Unknown14F = 0x0000014F,   // 335
        Unknown150 = 0x00000150,   // 336
        Unknown151 = 0x00000151,   // 337
        Unknown152 = 0x00000152,   // 338
        Unknown153 = 0x00000153,   // 339
        Unknown154 = 0x00000154,   // 340
        Unknown155 = 0x00000155,   // 341
        Unknown156 = 0x00000156,   // 342
        Unknown157 = 0x00000157,   // 343
        Unknown158 = 0x00000158,   // 344
        Unknown159 = 0x00000159,   // 345
        Unknown15A = 0x0000015A,   // 346
        Unknown15B = 0x0000015B,   // 347
        Unknown15C = 0x0000015C,   // 348
        Unknown15D = 0x0000015D,   // 349
        Unknown15E = 0x0000015E,   // 350
        Unknown15F = 0x0000015F,   // 351
        Unknown160 = 0x00000160,   // 352
        Unknown161 = 0x00000161,   // 353
        Unknown162 = 0x00000162,   // 354
        Unknown163 = 0x00000163,   // 355
        Unknown164 = 0x00000164,   // 356
        Unknown165 = 0x00000165,   // 357
        Unknown166 = 0x00000166,   // 358
        Unknown167 = 0x00000167,   // 359
        Unknown168 = 0x00000168,   // 360
        Unknown169 = 0x00000169,   // 361
        Unknown16A = 0x0000016A,   // 362
        Unknown16B = 0x0000016B,   // 363
        Unknown16C = 0x0000016C,   // 364
        Unknown16D = 0x0000016D,   // 365
        Unknown16E = 0x0000016E,   // 366
        Unknown16F = 0x0000016F,   // 367
        Unknown170 = 0x00000170,   // 368
        Unknown171 = 0x00000171,   // 369
        Unknown172 = 0x00000172,   // 370
        Unknown173 = 0x00000173,   // 371
        Unknown174 = 0x00000174,   // 372
        Unknown175 = 0x00000175,   // 373
        Unknown176 = 0x00000176,   // 374
        Unknown177 = 0x00000177,   // 375
        Unknown178 = 0x00000178,   // 376
        Unknown179 = 0x00000179,   // 377
        Unknown17A = 0x0000017A,   // 378
        Unknown17B = 0x0000017B,   // 379
        Unknown17C = 0x0000017C,   // 380
        Unknown17D = 0x0000017D,   // 381
        Unknown17E = 0x0000017E,   // 382
        Unknown17F = 0x0000017F,   // 383
        Unknown180 = 0x00000180,   // 384
        Unknown181 = 0x00000181,   // 385
        Unknown182 = 0x00000182,   // 386
        Unknown183 = 0x00000183,   // 387
        Unknown184 = 0x00000184,   // 388
        Unknown185 = 0x00000185,   // 389
        Unknown186 = 0x00000186,   // 390
        Unknown187 = 0x00000187,   // 391
        Unknown188 = 0x00000188,   // 392
        Unknown189 = 0x00000189,   // 393
        Unknown18A = 0x0000018A,   // 394
        Unknown18B = 0x0000018B,   // 395
        Unknown18C = 0x0000018C,   // 396
        Unknown18D = 0x0000018D,   // 397
        Unknown18E = 0x0000018E,   // 398
        Unknown18F = 0x0000018F,   // 399
        Unknown190 = 0x00000190,   // 400
        Unknown191 = 0x00000191,   // 401
        Unknown192 = 0x00000192,   // 402
        Unknown193 = 0x00000193,   // 403
        Unknown194 = 0x00000194,   // 404
        Unknown195 = 0x00000195,   // 405
        ServerAzureStackHCICore = 0x00000196,    // 406
        ServerTurbine = 0x00000197,    // 407
        ServerTurbineCore = 0x00000198,    // 408
        Unknown199 = 0x00000199,    // 409
        Unknown19A = 0x0000019A,    // 410
        Unknown19B = 0x0000019B,    // 411
        Unknown19C = 0x0000019C,    // 412
        Unknown19D = 0x0000019D,    // 413
        Unknown19E = 0x0000019E,    // 414
        Unknown19F = 0x0000019F,    // 415
        Unknown1A0 = 0x000001A0,    // 416
        Unknown1A1 = 0x000001A1,    // 417
        Unknown1A2 = 0x000001A2,    // 418
        Unknown1A3 = 0x000001A3,    // 419
        Unknown1A4 = 0x000001A4,    // 420
        Unknown1A5 = 0x000001A5,    // 421
        Unknown1A6 = 0x000001A6,    // 422
        Unknown1A7 = 0x000001A7,    // 423
        Unknown1A8 = 0x000001A8,    // 424
        Unknown1A9 = 0x000001A9,    // 425
        Unknown1AA = 0x000001AA,    // 426
        Unknown1AB = 0x000001AB,    // 427
        Unknown1AC = 0x000001AC,    // 428
        Unknown1AD = 0x000001AD,    // 429
        Unknown1AE = 0x000001AE,    // 430
        Unknown1AF = 0x000001AF,    // 431
        Unknown1B0 = 0x000001B0,    // 432
        Unknown1B1 = 0x000001B1,    // 433
        Unknown1B2 = 0x000001B2,    // 434
        Unknown1B3 = 0x000001B3,    // 435
        Unknown1B4 = 0x000001B4,    // 436
        Unknown1B5 = 0x000001B5,    // 437
        Unknown1B6 = 0x000001B6,    // 438
        Unknown1B7 = 0x000001B7,    // 439
        Unknown1B8 = 0x000001B8,    // 440
        Unknown1B9 = 0x000001B9,    // 441
        Unknown1BA = 0x000001BA,    // 442
        Unknown1BB = 0x000001BB,    // 443
        Unknown1BC = 0x000001BC,    // 444
        /*
        Unlicensed = unchecked((int)0xABCDABCD)    // 2882382797
        */
        /*
        *Known but "Unknown" SKUs：
        *CoreSystemServer
        *ServerAzureNanoCore
        *AnalogOneCore
        *CloudCore（Azure Fleet）
        */
    }

    public class CTAC
    {
        public string DeviceAttributes
        {
            get; set;
        }
        public string CallerAttributes
        {
            get; set;
        }
        public string Products
        {
            get; set;
        }
        public bool SyncCurrentVersionOnly
        {
            get; set;
        }

        public CTAC()
        {
        }

        public CTAC(OSSkuId ReportingSku,
                    string ReportingVersion,
                    MachineType MachineType,
                    string FlightRing,
                    string FlightingBranchName,
                    string BranchReadinessLevel,
                    string CurrentBranch,
                    string ReleaseType,
                    bool SyncCurrentVersionOnly,
                    bool IsStore = false,
                    string ContentType = "Mainline",
                    bool IsVbsEnabled = true) : base()
        {
            BuildCTAC(ReportingSku, ReportingVersion, MachineType, FlightRing, FlightingBranchName, BranchReadinessLevel, CurrentBranch, ReleaseType, SyncCurrentVersionOnly, IsStore, ContentType, IsVbsEnabled);
        }

        private void BuildCTAC(
            OSSkuId ReportingSku,
            string ReportingVersion,
            MachineType MachineType,
            string FlightRing,
            string FlightingBranchName,
            string BranchReadinessLevel,
            string CurrentBranch,
            string ReleaseType,
            bool SyncCurrentVersionOnly,
            bool IsStore = false,
            string content = "Mainline",
            bool IsVbsEnabled = true
        )
        {
            int flightEnabled = FlightRing == "Retail" ? 0 : 1;
            string App = IsStore ? "WU_STORE" : "WU_OS";

            string InstallType = "Client";
            string ReportingPFN = "Client.OS.rs2";
            string DeviceFamily = "Windows.Desktop";

            if (ReportingSku == OSSkuId.Holographic)
            {
                InstallType = "FactoryOS";
                ReportingPFN = "HOLOLENS.OS.rs2";
                DeviceFamily = "Windows.Holographic";
            }
            else if (ReportingSku == OSSkuId.IoTUAP)
            {
                InstallType = "IoTUAP";
                ReportingPFN = "IoTCore.OS.rs2";
                DeviceFamily = "Windows.IoTUAP";
            }
            else if (ReportingSku == OSSkuId.MobileCore)
            {
                InstallType = "MobileCore";
                ReportingPFN = "Mobile.OS.rs2";
                DeviceFamily = "Windows.Mobile";
            }
            else if (ReportingSku == OSSkuId.Lite)
            {
                InstallType = "FactoryOS";
                ReportingPFN = "WCOSDevice0.OS";
                DeviceFamily = "Windows.Core";
            }
            else if (ReportingSku == OSSkuId.Andromeda)
            {
                InstallType = "FactoryOS";
                ReportingPFN = "WCOSDevice1.OS";
                DeviceFamily = "Windows.Core";
            }
            else if (ReportingSku == OSSkuId.HubOS)
            {
                InstallType = "FactoryOS";
                ReportingPFN = "WCOSDevice2.OS";
                DeviceFamily = "Windows.Core";
            }
            else if (ReportingSku.ToString().Contains("Server", StringComparison.InvariantCultureIgnoreCase) && ReportingSku.ToString().Contains("Core", StringComparison.InvariantCultureIgnoreCase))
            {
                InstallType = "Server Core";
                ReportingPFN = "Server.OS";
                DeviceFamily = "Windows.Server";
            }
            else if (ReportingSku.ToString().Contains("Server", StringComparison.InvariantCultureIgnoreCase) && !ReportingSku.ToString().Contains("Core", StringComparison.InvariantCultureIgnoreCase))
            {
                InstallType = "Server";
                ReportingPFN = "Server.OS";
                DeviceFamily = "Windows.Server";
            }
            else if (ReportingSku == OSSkuId.PPIPro)
            {
                DeviceFamily = "Windows.Team";
            }

            DeviceAttributes = "E:IsContainerMgrInstalled=1&" +
                                    $"FlightRing={FlightRing}&" +
                                    "TelemetryLevel=3&" +
                                    "HidOverGattReg=C:\\WINDOWS\\System32\\DriverStore\\FileRepository\\hidbthle.inf_amd64_0fc6b7cd4ccbc55c\\Microsoft.Bluetooth.Profiles.HidOverGatt.dll&" +
                                    "AppVer=0.0.0.0&" +
                                    "IsAutopilotRegistered=0&" +
                                    "ProcessorIdentifier=Intel64 Family 6 Model 151 Stepping 2&" +
                                    "OEMModel=RM-1085_1045&" +
                                    "ProcessorManufacturer=GenuineIntel&" +
                                    "InstallDate=1577722757&" +
                                    "OEMModelBaseBoard=OEM Board Name&" +
                                    $"BranchReadinessLevel={BranchReadinessLevel}&" +
                                    "DataExpDateEpoch_20H1=1593425114&" +
                                    "IsCloudDomainJoined=0&" +
                                    "Bios=2019&" +
                                    "DchuAmdGrfxVen=4098&" +
                                    "IsDeviceRetailDemo=0&" +
                                    $"FlightingBranchName={FlightingBranchName}&" +
                                    "OSUILocale=en-US&" +
                                    $"DeviceFamily={DeviceFamily}&" +
                                    "UpgEx_20H1=Green&" +
                                    $"WuClientVer={ReportingVersion}&" +
                                    $"IsFlightingEnabled={flightEnabled}&" +
                                    $"OSSkuId={(int)ReportingSku}&" +
                                    "GStatus_20H1=2&" +
                                    $"App={App}&" +
                                    $"CurrentBranch={CurrentBranch}&" +
                                    "InstallLanguage=en-US&" +
                                    "OEMName_Uncleaned=MICROSOFTMDG&" +
                                    $"InstallationType={InstallType}&" +
                                    "AttrDataVer=264&" +
                                    "IsEdgeWithChromiumInstalled=1&" +
                                    "TimestampEpochString_20H1=1593425114&" +
                                    $"OSVersion={ReportingVersion}&" +
                                    "IsMDMEnrolled=0&" +
                                    "TencentType=1&" +
                                    $"FlightContent={content}&" +
                                    "ActivationChannel=Retail&" +
                                    "Steam=URL:steam protocol&" +
                                    "Free=gt64&" +
                                    "TencentReg=79 d0 01 d7 9f 54 d5 01&" +
                                    "FirmwareVersion=7704&" +
                                    "DchuAmdGrfxExists=1&" +
                                    "SdbVer_20H1=2000000000&" +
                                    "UpgEx_CO21H2=Green&" +
                                    //$"OSArchitecture={MachineType.ToString().ToUpper()}&" +
                                    $"OSArchitecture=AMD64&" +
                                    "DefaultUserRegion=244&" +
                                    $"ReleaseType={ReleaseType}&" +
                                    "UpdateManagementGroup=2&" +
                                    "MobileOperatorCommercialized=000-88&" +
                                    "PhoneTargetingName=Lumia 950 XL&" +
                                    "AllowInPlaceUpgrade=1&" +
                                    "AllowUpgradesWithUnsupportedTPMOrCPU=1&" +
                                    "CloudPBR=1&" +
                                    "DataExpDateEpoch_19H1=1593425114&" +
                                    "DataExpDateEpoch_21H1=1593425114&" +
                                    "DataExpDateEpoch_21H2=1593425114&" +
                                    "DataExpDateEpoch_CO21H2=1593425114&" +
                                    "DataExpDateEpoch_CO21H2Setup=1593425114&" +
                                    "DataVer_RS5=2000000000&" +
                                    "DUScan=1&" +
                                    "EKB19H2InstallCount=1&" +
                                    "EKB19H2InstallTimeEpoch=1255000000&" +
                                    "GenTelRunTimestamp_19H1=1593425114&" +
                                    "GStatus_19H1=2&" +
                                    "GStatus_19H1Setup=2&" +
                                    "GStatus_20H1Setup=2&" +
                                    "GStatus_21H2=2&" +
                                    "GStatus_CO21H2=2&" +
                                    "GStatus_CO21H2Setup=2&" +
                                    "GStatus_RS5=2&" +
                                    "MediaBranch=&" +
                                    "ProcessorModel=12th Gen Intel(R) Core(TM) i9-12900K&" +
                                    "SdbVer_19H1=2000000000&" +
                                    "SecureBootCapable=1&" +
                                    "TimestampEpochString_19H1=1593425114&" +
                                    "TimestampEpochString_21H1=1593425114&" +
                                    "TimestampEpochString_21H2=1593425114&" +
                                    "TimestampEpochString_CO21H2=1593425114&" +
                                    "TimestampEpochString_CO21H2Setup=1593425114&" +
                                    "TPMVersion=2&" +
                                    "UpdateOfferedDays=0&" +
                                    "UpgEx_19H1=Green&" +
                                    "UpgEx_21H1=Green&" +
                                    "UpgEx_21H2=Green&" +
                                    "UpgEx_NI22H2=Green&" +
                                    "UpgEx_RS5=Green&" +
                                    "UpgradeEligible=1&" +
                                    "Version_RS5=2000000000&" +
                                    $"IsRetailOS={FlightRing == "Retail"}&" +
                                    $"MediaVersion={ReportingVersion}" +
                                    $"IsVbsEnabled={(IsVbsEnabled ? 1 : 0)}";

            if (ReportingSku is OSSkuId.EnterpriseS or OSSkuId.EnterpriseSN || ReportingSku.ToString().Contains("Server", StringComparison.InvariantCultureIgnoreCase))
            {
                DeviceAttributes += "&BlockFeatureUpdates=1";
            }

            if (ReportingSku == OSSkuId.Holographic)
            {
                DeviceAttributes += $"&OneCoreFwV={ReportingVersion}&" +
                                        $"OneCoreSwV={ReportingVersion}&" +
                                        "OneCoreManufacturerModelName=HoloLens&" +
                                        "OneCoreManufacturer=Microsoft Corporation&" +
                                        "OneCoreOperatorName=000-88";
            }
            else if (ReportingSku == OSSkuId.HubOS)
            {
                DeviceAttributes += $"&OneCoreFwV={ReportingVersion}&" +
                                        $"OneCoreSwV={ReportingVersion}&" +
                                        "OneCoreManufacturerModelName=Surface Hub 2X&" +
                                        "OneCoreManufacturer=Microsoft Corporation&" +
                                        "OneCoreOperatorName=000-88";
            }
            else if (ReportingSku == OSSkuId.Andromeda)
            {
                DeviceAttributes += $"&OneCoreFwV={ReportingVersion}&" +
                                        $"OneCoreSwV={ReportingVersion}&" +
                                        "OneCoreManufacturerModelName=Andromeda&" +
                                        "OneCoreManufacturer=Microsoft Corporation&" +
                                        "OneCoreOperatorName=000-88";
            }
            else if (ReportingSku == OSSkuId.Lite)
            {
                DeviceAttributes += "&Product=ModernPC";
                DeviceAttributes += $"&OneCoreFwV={ReportingVersion}&" +
                                        $"OneCoreSwV={ReportingVersion}&" +
                                        "OneCoreManufacturerModelName=Santorini&" +
                                        "OneCoreManufacturer=Microsoft Corporation&" +
                                        "OneCoreOperatorName=000-88";
            }

            CallerAttributes = "E:Interactive=1&IsSeeker=1&SheddingAware=1&";
            if (IsStore)
            {
                CallerAttributes += "Acquisition=1&Id=Acquisition%3BMicrosoft.WindowsStore_8wekyb3d8bbwe&";
            }
            else
            {
                CallerAttributes += "Id=UpdateOrchestrator&";
            }
            Products = "";
            if (!IsStore)
            {
                Products = $"PN={ReportingPFN}.{MachineType}&Branch={CurrentBranch}&PrimaryOSProduct=1&Repairable=1&V={ReportingVersion};";
            }

            this.SyncCurrentVersionOnly = SyncCurrentVersionOnly;
        }

        public static string GenerateDeviceId(string Manufacturer, string Family, string Product, string Sku)
        {
            string inputString = Manufacturer + "&" + Family + "&" + Product + "&" + Sku;
            Guid guidFromString = ComputerHardwareIDProvider.Class5GuidFromString(inputString);
            string guidString = $"{{{guidFromString}}}";
            return guidString;
        }
    }
}
