﻿#region License

// https://github.com/TheBerkin/Sagen
// 
// Copyright (c) 2017 Nicholas Fleck
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in the
// Software without restriction, including without limitation the rights to use, copy,
// modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,
// and to permit persons to whom the Software is furnished to do so, subject to the
// following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

#endregion

namespace Sagen
{
    /// <summary>
    /// Configures the phonetic characteristics of a voice.
    /// </summary>
    public partial class Voice
    {
        public double SentenceBetweenTime { get; set; }
        public double EllipsisPause { get; set; }
        public double ClausePauseTime { get; set; }
        public bool VerbalizeNumbers { get; set; } = true;

        /// <summary>
        /// Sets the gender of the voice, which affects the frequency range for each vocal register.
        /// </summary>
        public VoiceGender Gender { get; set; } = VoiceGender.Male;

        /// <summary>
        /// Controls the voicing gain. Values below one create a whispering effect.
        /// <para>Range: [0, &#8734;)</para>
        /// <para>Default: 1.0</para>
        /// </summary>
        public double VoicingGain { get; set; } = 1.0;

        /// <summary>
        /// Controls the strength of glottal consonants.
        /// </summary>
        public double GlottalForce { get; set; } = 1.0;

        /// <summary>
        /// Controls the overall strength of fricatives.
        /// </summary>
        public double FricativeForce { get; set; } = 1.0;

        /// <summary>
        /// Controls the strength of dental fricative bands. Set to zero for toothless mode.
        /// </summary>
        public double DentalForce { get; set; } = 1.0;

        /// <summary>
        /// Controls the strength of plosives. Set to zero for lipless mode. Set to above one for spitting animal.
        /// </summary>
        public double PlosiveForce { get; set; } = 1.0;

        /// <summary>
        /// Controls the strength of bands in fricatives, which give them their characteristic sounds.
        /// Values below one create a lisp effect. Values above one create a really annoying effect.
        /// </summary>
        public double FricativeBandStrength { get; set; } = 1.0;

        /// <summary>
        /// Head size represents the vocal tract length of the speaker, which will shift the formants up or down.
        /// Values greater than 1.0 cause the voice to sound more "throaty". Values less than 1.0 are ideal for more
        /// feminine/childlike voices.
        /// <para>
        /// The recommended maximum value for this parameter is 2.0, as higher values may cause speech to become
        /// incomprehensible.
        /// </para>
        /// <para>Range = (0, &#8734;), Default = 1.0</para>
        /// </summary>
        public double HeadSize { get; set; } = 1.0;

        /// <summary>
        /// Controls how fast F0 ascends when shaking.
        /// <para>Range: (0, &#8734;) - Default: 12.0</para>
        /// </summary>
        public double VoiceShakeAscendRate { get; set; } = 12.0;

        /// <summary>
        /// Controls how fast F0 descends when shaking.
        /// <para>Range: (0, &#8734;) - Default: 5.0</para>
        /// </summary>
        public double VoiceShakeDescendRate { get; set; } = 5.0;

        /// <summary>
        /// The maximum offset, in hertz, that F0 can ascend or descend when shaking.
        /// <para>Range: (0, &#8734;) - Default: 3.0</para>
        /// </summary>
        public double VoiceShakeAmountHz { get; set; } = 3.0;

        /// <summary>
        /// Master multiplier of fundamental frequency.
        /// <para>Range: (0, &#8734;) - Default: 1.0</para>
        /// </summary>
        public double FundamentalFrequencyMultiplier { get; set; } = 1.0;

        /// <summary>
        /// Vibrato amount in octaves.
        /// <para>Range: [0, &#8734;) - Default: 0.0</para>
        /// </summary>
        public double VibratoAmount { get; set; } = 0.0;

        /// <summary>
        /// Vibrato speed in hertz.
        /// <para>Range: (0, &#8734;) - Default: 8.0</para>
        /// </summary>
        public double VibratoSpeed { get; set; } = 8.0;

        /// <summary>
        /// Master nasalization level.
        /// <para>Range: [0, 1] - Default: 0.0</para>
        /// </summary>
        public double Nasalization { get; set; } = 0.0;

        /// <summary>
        /// Breathiness level.
        /// <para>Range: [0, 1] - Default: 0.0</para>
        /// </summary>
        public double Breathiness { get; set; } = 0.0;

        /// <summary>
        /// Quantization quality. Set to 0 to disable.
        /// <para>Range: [0, &#8734;) - Default: 0</para>
        /// </summary>
        public int Quantization { get; set; } = 0;

        /// <summary>
        /// The frequency offset of F4 in Hertz. This value is inversely scaled by head size.
        /// <para>Range: (-&#8734;, &#8734;) - Default: 0.0</para>
        /// </summary>
        public double FrequencyOffsetF4 { get; set; } = 0.0;

        /// <summary>
        /// The frequency offset of F5 in Hertz. This value is inversely scaled by head size.
        /// <para>Range: (-&#8734;, &#8734;) - Default: 0.0</para>
        /// </summary>
        public double FrequencyOffsetF5 { get; set; } = 0.0;

        /// <summary>
        /// The bandwidth of the fourth formant in Hertz.
        /// <para>Range: (0, &#8734;) - Default: 280.0</para>
        /// </summary>
        public double BandwidthF4 { get; set; } = 180.0;

        /// <summary>
        /// The bandwidth of the fifth formant in Hertz.
        /// <para>Range: (0, &#8734;) - Default: 300.0</para>
        /// </summary>
        public double BandwidthF5 { get; set; } = 250.0;

        /// <summary>
        /// The relative gain of the formants.
        /// <para>Range: [0, &#8734;) - Default: 1.0</para>
        /// </summary>
        public double FormantGain { get; set; } = 1.0;

        /// <summary>
        /// Controls the amount of laryngealization (creakiness) in the voice.
        /// <para>Range: [0, 1] - Default: 0.0</para>
        /// </summary>
        public double Creakiness { get; set; } = 0.0;

        /// <summary>
        /// Controls the factor by which the pitch is multiplied at the start of a sentence during the pickup period.
        /// <para>Range: (0, &#8734;) - Default: 0.55</para>
        /// </summary>
        public double PickupSlope { get; set; } = 0.55;

        /// <summary>
        /// Controls the length of the pickup period in seconds.
        /// <para>Range: (0, &#8734;) - Default: 0.125</para>
        /// </summary>
        public double PickupLength { get; set; } = 0.125;

        /// <summary>
        /// Controls the length of time in seconds it takes for pitch to rise on stressed syllables.
        /// <para>Range: [0, &#8734;) - Default: 0.1</para>
        /// </summary>
        public double Quickness { get; set; } = 0.1;

        /// <summary>
        /// Controls the change in pitch, in Hertz, that occurs on stressed syllables.
        /// <para>Range: (-&#8734;, &#8734;) - Default: 10.0</para>
        /// </summary>
        public double StressRise { get; set; } = 10.0;

        /// <summary>
        /// Controls the change in pitch, in Hertz, that occurs on the first stressed syllable in a sentence.
        /// <para>Range: (-&#8734;, &#8734;) - Default: 16.0</para>
        /// </summary>
        public double HatRise { get; set; } = 16.0;

        /// <summary>
        /// Time in seconds it takes the glottis to close.
        /// <para>Range: [0, &#8734;) - Default: 0.04</para>
        /// </summary>
        public double GlottisCloseTime { get; set; } = 0.04;

        /// <summary>
        /// Time in seconds it takes the glottis to open.
        /// <para>Range: [0, &#8734;) - Default: 0.02</para>
        /// </summary>
        public double GlottisOpenTime { get; set; } = 0.02;
    }

    /// <summary>
    /// Provides voice gender categories, which affect vocal characteristics such as pitch, vocal tract length, and presence of
    /// higher formants.
    /// </summary>
    public enum VoiceGender
    {
        /// <summary>
        /// Indicates an adult male voice.
        /// </summary>
        Male,

        /// <summary>
        /// Indicates an adult female voice.
        /// </summary>
        Female,

        /// <summary>
        /// Indicates a child under ten years old, for which gender is generally indistinguishable by voice.
        /// </summary>
        Child
    }
}