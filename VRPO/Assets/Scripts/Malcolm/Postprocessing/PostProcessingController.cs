// Utility scripts for the post processing stack
// https://github.com/keijiro/PostProcessingUtilities
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.PostProcessing.Utilities
{
    [RequireComponent(typeof(PostProcessingBehaviour))]
    public class PostProcessingController : MonoBehaviour
    #region Public structs
    {
        public bool testchange1 = true;
        public float speed;
        public float antiAliasingSpeed;
        public float ambientOcclusionSpeed;
        public float screenSpaceReflectionSpeed;
        public float fogSpeed;
        public float depthOfFieldSpeed;
        public float motionBlurSpeed;
        public float eyeAdaptationSpeed;
        public float bloomSpeed;
        public float colorGradingSpeed;
        public float userLutSpeed;
        public float chromaticAberrationSpeed;
        public float grainSpeed;
        public float vignetteSpeed;
        public PostProcessingProfile profile2;
        public PostProcessingProfile defaultProfile;

        bool antiAliasingChange;
        public AntialiasingModel.Settings antiAliasing;

        bool ambientOcclusionChange;
        public AmbientOcclusionModel.Settings ambientOcclusion;

        bool screenSpaceReflectionChange;
        public ScreenSpaceReflectionModel.Settings screenSpaceReflection;

        bool fogChange;
        public FogModel.Settings fog;

        bool depthOfFieldChange;
        public DepthOfFieldModel.Settings depthOfField;

        bool motionBlurChange;
        public MotionBlurModel.Settings motionBlur;

        bool eyeAdaptationChange;
        public EyeAdaptationModel.Settings eyeAdaptation;

        bool bloomChange;
        public BloomModel.Settings bloom;

        bool colorGradingChange;
        public ColorGradingModel.Settings colorGrading;

        bool userLutChange;
        public UserLutModel.Settings userLut;

        bool chromaticAberrationChange;
        public ChromaticAberrationModel.Settings chromaticAberration;

        bool grainChange;
        public GrainModel.Settings grain;

        bool vignetteChange;
        public VignetteModel.Settings vignette;

        #endregion

        #region Private members

        // Cloned profile
        PostProcessingProfile _profile;
        PostProcessingProfile _profile2;

        #endregion

        #region MonoBehaviour functions
        private KeyCode Blackout;
        void Start()
        {
            #region Post Processing Stuff
            // Replace the profile with its clone.
            var postfx = GetComponent<PostProcessingBehaviour>();
            _profile = Instantiate<PostProcessingProfile>(postfx.profile);
            postfx.profile = _profile;

            var postfx2 = profile2;
            _profile2 = Instantiate<PostProcessingProfile>(postfx2);
            postfx2 = _profile2;

            //speed = 1.0f;
            //antiAliasingSpeed = 1.0f;
            //ambientOcclusionSpeed = 1.0f;
            //screenSpaceReflectionSpeed = 1.0f;
            //depthOfFieldSpeed = 1.0f;
            //motionBlurSpeed = 1.0f;
            //eyeAdaptationSpeed = 1.0f;
            //bloomSpeed = 1.0f;
            //colorGradingSpeed = 1.0f;
            //userLutSpeed = 1.0f;
            //chromaticAberrationSpeed = 1.0f;
            //grainSpeed = 1.0f;
            //vignetteSpeed = 1.0f;
            // Initialize the public structs with the current profile.
            antiAliasingChange = false;
            antiAliasing = _profile.antiAliasing.settings;

            ambientOcclusionChange = false;
            ambientOcclusion = _profile.ambientOcclusion.settings;

            screenSpaceReflectionChange = false;
            screenSpaceReflection = _profile.screenSpaceReflection.settings;

            fogChange = false;
            fog = _profile.fog.settings;

            depthOfFieldChange = false;
            depthOfField = _profile.depthOfField.settings;

            motionBlurChange = false;
            motionBlur = _profile.motionBlur.settings;

            eyeAdaptationChange = false;
            eyeAdaptation = _profile.eyeAdaptation.settings;

            bloomChange = false;
            bloom = _profile.bloom.settings;

            colorGradingChange = false;
            colorGrading = _profile.colorGrading.settings;

            userLutChange = false;
            userLut = _profile.userLut.settings;

            chromaticAberrationChange = false;
            chromaticAberration = _profile.chromaticAberration.settings;

            grainChange = false;
            grain = _profile.grain.settings;

            vignetteChange = false;
            vignette = _profile.vignette.settings;
            #endregion

            Blackout = KeyCode.F1;
        }
        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.name == "PostProfilingChange")
            {
                _profile2 = col.gameObject.GetComponent<ProfileHolder>().profile;
                profile2 = col.gameObject.GetComponent<ProfileHolder>().profile;
                testchange1 = false;
            }
        }
        void OnTriggerExit(Collider col)
        {
            if (col.gameObject.name == "PostProfilingChange")
            {
                _profile2 = defaultProfile;
                testchange1 = false;
            }
        }
        void ProfileChange()
        {

            #region Antialiasing
            if ((antiAliasingChange == false && _profile2.antiAliasing.enabled == false) || _profile.antiAliasing.enabled == false)
            {
                antiAliasing.taaSettings.jitterSpread = 0.0f;
                antiAliasing.taaSettings.sharpen = 0.0f;
                antiAliasing.taaSettings.stationaryBlending = 0.0f;
                antiAliasing.taaSettings.motionBlending = 0.0f;
                _profile.antiAliasing.settings = antiAliasing;
            }
            antiAliasingChange = true;
            if (_profile2.antiAliasing.enabled == false && antiAliasingChange == true)
            {
                if (antiAliasing.taaSettings.jitterSpread > 0)
                {
                    antiAliasing.taaSettings.jitterSpread -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                }
                else
                {
                    antiAliasing.taaSettings.jitterSpread = 0;
                }
                if (antiAliasing.taaSettings.sharpen > 0)
                {
                    antiAliasing.taaSettings.sharpen -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                }
                else
                {
                    antiAliasing.taaSettings.sharpen = 0;
                }
                if (antiAliasing.taaSettings.stationaryBlending > 0)
                {
                    antiAliasing.taaSettings.stationaryBlending -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                }
                else
                {
                    antiAliasing.taaSettings.stationaryBlending = 0;
                }
                if (antiAliasing.taaSettings.motionBlending > 0)
                {
                    antiAliasing.taaSettings.motionBlending -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                }
                else
                {
                    antiAliasing.taaSettings.motionBlending = 0;
                }
            }
            _profile.antiAliasing.settings = antiAliasing;

            if ((antiAliasing.taaSettings.jitterSpread < 0 && antiAliasing.taaSettings.sharpen < 0 && antiAliasing.taaSettings.stationaryBlending < 0 && antiAliasing.taaSettings.motionBlending < 0) || (_profile2.antiAliasing.enabled == false && _profile.antiAliasing.enabled == false))
            {
                antiAliasing.taaSettings.jitterSpread = 0.0f;
                antiAliasing.taaSettings.sharpen = 0.0f;
                antiAliasing.taaSettings.stationaryBlending = 0.0f;
                antiAliasing.taaSettings.motionBlending = 0.0f;
                antiAliasing.fxaaSettings = _profile2.antiAliasing.settings.fxaaSettings;
                antiAliasing.method = _profile2.antiAliasing.settings.method;
                _profile.antiAliasing.settings = antiAliasing;
                _profile.antiAliasing.enabled = false;
                antiAliasingChange = false;
            }
            antiAliasing = _profile.antiAliasing.settings;
            if (_profile2.antiAliasing.enabled == true)
                _profile.antiAliasing.enabled = _profile2.antiAliasing.enabled;

            if (_profile.antiAliasing.enabled == true && _profile2.antiAliasing.enabled == true && antiAliasingChange == true)
            {
                antiAliasing.fxaaSettings = _profile2.antiAliasing.settings.fxaaSettings;
                antiAliasing.method = _profile2.antiAliasing.settings.method;
                if (antiAliasing.taaSettings.jitterSpread != _profile2.antiAliasing.settings.taaSettings.jitterSpread)
                {
                    if (antiAliasing.taaSettings.jitterSpread > _profile2.antiAliasing.settings.taaSettings.jitterSpread)
                    {
                        antiAliasing.taaSettings.jitterSpread -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                    else
                    {
                        antiAliasing.taaSettings.jitterSpread += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                }

                if (antiAliasing.taaSettings.sharpen != _profile2.antiAliasing.settings.taaSettings.sharpen)
                {
                    if (antiAliasing.taaSettings.sharpen > _profile2.antiAliasing.settings.taaSettings.sharpen)
                    {
                        antiAliasing.taaSettings.sharpen -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                    else
                    {
                        antiAliasing.taaSettings.sharpen += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                }

                if (antiAliasing.taaSettings.stationaryBlending != _profile2.antiAliasing.settings.taaSettings.stationaryBlending)
                {
                    if (antiAliasing.taaSettings.stationaryBlending > _profile2.antiAliasing.settings.taaSettings.stationaryBlending)
                    {
                        antiAliasing.taaSettings.stationaryBlending -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                    else
                    {
                        antiAliasing.taaSettings.stationaryBlending += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                }
                if (antiAliasing.taaSettings.motionBlending != _profile2.antiAliasing.settings.taaSettings.motionBlending)
                {
                    if (antiAliasing.taaSettings.motionBlending > _profile2.antiAliasing.settings.taaSettings.motionBlending)
                    {
                        antiAliasing.taaSettings.motionBlending -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                    else
                    {
                        antiAliasing.taaSettings.motionBlending += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * antiAliasingSpeed;
                    }
                }

                _profile.antiAliasing.settings = antiAliasing;
            }
            #endregion

            #region Ambient Occlusion
            if ((ambientOcclusionChange == false && _profile2.ambientOcclusion.enabled == false) || _profile.ambientOcclusion.enabled == false)
            {
                ambientOcclusion.intensity = 0.0f;
                ambientOcclusion.radius = 0.0f;
                _profile.ambientOcclusion.settings = ambientOcclusion;
            }
            ambientOcclusionChange = true;
            if (_profile2.ambientOcclusion.enabled == false && ambientOcclusionChange == true)
            {
                if (ambientOcclusion.intensity > 0)
                {
                    ambientOcclusion.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * ambientOcclusionSpeed;
                }
                else
                {
                    ambientOcclusion.intensity = 0;
                }
                if (ambientOcclusion.radius > 0)
                {
                    ambientOcclusion.radius -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * ambientOcclusionSpeed;
                }
                else
                {
                    ambientOcclusion.radius = 0;
                }
            }
            _profile.ambientOcclusion.settings = ambientOcclusion;

            if ((ambientOcclusion.intensity < 0 && ambientOcclusion.radius < 0) || (_profile2.ambientOcclusion.enabled == false && _profile.ambientOcclusion.enabled == false))
            {
                ambientOcclusion.intensity = 0.0f;
                ambientOcclusion.radius = 0.0f;
                ambientOcclusion.sampleCount = _profile2.ambientOcclusion.settings.sampleCount;
                ambientOcclusion.downsampling = _profile2.ambientOcclusion.settings.downsampling;
                ambientOcclusion.forceForwardCompatibility = _profile2.ambientOcclusion.settings.forceForwardCompatibility;
                ambientOcclusion.ambientOnly = _profile2.ambientOcclusion.settings.ambientOnly;
                ambientOcclusion.highPrecision = _profile2.ambientOcclusion.settings.highPrecision;
                _profile.ambientOcclusion.settings = ambientOcclusion;
                _profile.ambientOcclusion.enabled = false;
                ambientOcclusionChange = false;
            }

            ambientOcclusion = _profile.ambientOcclusion.settings;
            if (_profile2.ambientOcclusion.enabled == true)
                _profile.ambientOcclusion.enabled = _profile2.ambientOcclusion.enabled;
            if (_profile.ambientOcclusion.enabled == true && _profile2.ambientOcclusion.enabled == true)
            {
                ambientOcclusion.sampleCount = _profile2.ambientOcclusion.settings.sampleCount;
                ambientOcclusion.downsampling = _profile2.ambientOcclusion.settings.downsampling;
                ambientOcclusion.forceForwardCompatibility = _profile2.ambientOcclusion.settings.forceForwardCompatibility;
                ambientOcclusion.ambientOnly = _profile2.ambientOcclusion.settings.ambientOnly;
                ambientOcclusion.highPrecision = _profile2.ambientOcclusion.settings.highPrecision;
                if (ambientOcclusion.intensity != _profile2.ambientOcclusion.settings.intensity)
                {
                    if (ambientOcclusion.intensity > _profile2.ambientOcclusion.settings.intensity)
                    {
                        ambientOcclusion.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * ambientOcclusionSpeed;
                    }
                    else
                    {
                        ambientOcclusion.intensity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * ambientOcclusionSpeed;
                    }
                }

                if (ambientOcclusion.radius != _profile2.ambientOcclusion.settings.radius)
                {
                    if (ambientOcclusion.radius > _profile2.ambientOcclusion.settings.radius)
                    {
                        ambientOcclusion.radius -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * ambientOcclusionSpeed;
                    }
                    else
                    {
                        ambientOcclusion.radius += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * ambientOcclusionSpeed;
                    }
                }
                _profile.ambientOcclusion.settings = ambientOcclusion;
            }
            #endregion

            #region Screen Space Reflection

            if ((screenSpaceReflectionChange == false && _profile2.screenSpaceReflection.enabled == false) || _profile.screenSpaceReflection.enabled == false)
            {
                screenSpaceReflection.intensity.reflectionMultiplier = 0.0f;
                _profile.screenSpaceReflection.settings = screenSpaceReflection;
            }
            screenSpaceReflectionChange = true;

            if (_profile2.screenSpaceReflection.enabled == false && screenSpaceReflectionChange == true)
            {
                if (screenSpaceReflection.intensity.reflectionMultiplier > 0)
                {
                    screenSpaceReflection.intensity.reflectionMultiplier -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * fogSpeed;
                }
                else
                {
                    screenSpaceReflection.intensity.reflectionMultiplier = 0;
                }
            }
            if ((_profile2.screenSpaceReflection.enabled == false && screenSpaceReflectionChange == true && screenSpaceReflection.intensity.reflectionMultiplier <= 0.0f) || (_profile2.screenSpaceReflection.enabled == false && _profile.screenSpaceReflection.enabled == false))
            {
                screenSpaceReflection.intensity.reflectionMultiplier = 0.0f;
                screenSpaceReflection.reflection.blendType = _profile2.screenSpaceReflection.settings.reflection.blendType;
                screenSpaceReflection.reflection.reflectionQuality = _profile2.screenSpaceReflection.settings.reflection.reflectionQuality;
                screenSpaceReflection.reflection.maxDistance = _profile2.screenSpaceReflection.settings.reflection.maxDistance;
                screenSpaceReflection.reflection.iterationCount = _profile2.screenSpaceReflection.settings.reflection.iterationCount;
                screenSpaceReflection.reflection.stepSize = _profile2.screenSpaceReflection.settings.reflection.stepSize;
                screenSpaceReflection.reflection.widthModifier = _profile2.screenSpaceReflection.settings.reflection.widthModifier;
                screenSpaceReflection.reflection.reflectionBlur = _profile2.screenSpaceReflection.settings.reflection.reflectionBlur;
                screenSpaceReflection.reflection.reflectBackfaces = _profile2.screenSpaceReflection.settings.reflection.reflectBackfaces;
                screenSpaceReflection.intensity.fadeDistance = _profile2.screenSpaceReflection.settings.intensity.fadeDistance;
                screenSpaceReflection.intensity.fresnelFade = _profile2.screenSpaceReflection.settings.intensity.fresnelFade;
                screenSpaceReflection.intensity.fresnelFadePower = _profile2.screenSpaceReflection.settings.intensity.fresnelFadePower;
                screenSpaceReflection.screenEdgeMask.intensity = _profile2.screenSpaceReflection.settings.screenEdgeMask.intensity;
                _profile.screenSpaceReflection.enabled = false;
                screenSpaceReflectionChange = false;
            }
            if (_profile2.screenSpaceReflection.enabled == true)
                _profile.screenSpaceReflection.enabled = _profile2.screenSpaceReflection.enabled;

            if (_profile.screenSpaceReflection.enabled == true && _profile2.screenSpaceReflection.enabled == true)
            {
                screenSpaceReflection.reflection.blendType = _profile2.screenSpaceReflection.settings.reflection.blendType;
                screenSpaceReflection.reflection.reflectionQuality = _profile2.screenSpaceReflection.settings.reflection.reflectionQuality;
                screenSpaceReflection.reflection.maxDistance = _profile2.screenSpaceReflection.settings.reflection.maxDistance;
                screenSpaceReflection.reflection.iterationCount = _profile2.screenSpaceReflection.settings.reflection.iterationCount;
                screenSpaceReflection.reflection.stepSize = _profile2.screenSpaceReflection.settings.reflection.stepSize;
                screenSpaceReflection.reflection.widthModifier = _profile2.screenSpaceReflection.settings.reflection.widthModifier;
                screenSpaceReflection.reflection.reflectionBlur = _profile2.screenSpaceReflection.settings.reflection.reflectionBlur;
                screenSpaceReflection.reflection.reflectBackfaces = _profile2.screenSpaceReflection.settings.reflection.reflectBackfaces;
                screenSpaceReflection.intensity.fadeDistance = _profile2.screenSpaceReflection.settings.intensity.fadeDistance;
                screenSpaceReflection.intensity.fresnelFade = _profile2.screenSpaceReflection.settings.intensity.fresnelFade;
                screenSpaceReflection.intensity.fresnelFadePower = _profile2.screenSpaceReflection.settings.intensity.fresnelFadePower;
                screenSpaceReflection.screenEdgeMask.intensity = _profile2.screenSpaceReflection.settings.screenEdgeMask.intensity;
                if (screenSpaceReflection.intensity.reflectionMultiplier != _profile2.screenSpaceReflection.settings.intensity.reflectionMultiplier)
                {
                    if (screenSpaceReflection.intensity.reflectionMultiplier > _profile2.screenSpaceReflection.settings.intensity.reflectionMultiplier)
                    {
                        screenSpaceReflection.intensity.reflectionMultiplier -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * screenSpaceReflectionSpeed;
                    }
                    else
                    {
                        screenSpaceReflection.intensity.reflectionMultiplier += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * screenSpaceReflectionSpeed;
                    }
                }

                _profile.screenSpaceReflection.settings = screenSpaceReflection;
            }
            #endregion

            #region Fog
            {
                //_profile.fog.enabled = _profile2.fog.enabled;
                //fog = _profile2.fog.settings;
                //_profile.fog.settings = fog;

            }
            #endregion

            #region Depth of Field

            if ((depthOfFieldChange == false && _profile2.depthOfField.enabled == false) || _profile.depthOfField.enabled == false)
            {
                depthOfField.focusDistance = 0.0f;
                depthOfField.aperture = 0.0f;
                depthOfField.focalLength = 0.0f;
                _profile.depthOfField.settings = depthOfField;
            }
            depthOfFieldChange = true;
            if (_profile2.depthOfField.enabled == false && depthOfFieldChange == true)
            {
                if (depthOfField.focusDistance > 0)
                    depthOfField.focusDistance -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 10 * depthOfFieldSpeed;
                else
                {
                    depthOfField.focusDistance = 0;
                }
                if (depthOfField.aperture > 0)
                    depthOfField.aperture -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * depthOfFieldSpeed;
                else
                {
                    depthOfField.aperture = 0;
                }
                if (depthOfField.focalLength > 0)
                    depthOfField.focalLength -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 5 * depthOfFieldSpeed;
                else
                {
                    depthOfField.focalLength = 0;
                }
                _profile.depthOfField.settings = depthOfField;
            }

            if ((_profile2.depthOfField.enabled == false && depthOfFieldChange == true && depthOfField.focusDistance <= 0) || (_profile2.depthOfField.enabled == false && _profile.depthOfField.enabled == false))
            {
                depthOfField.focusDistance = 0.0f;
                depthOfField.aperture = 0.0f;
                depthOfField.focalLength = 0.0f;
                _profile.depthOfField.enabled = _profile2.depthOfField.enabled;
                _profile.depthOfField.settings = depthOfField;
                _profile.depthOfField.enabled = false;
                depthOfFieldChange = false;
            }
            if (depthOfField.aperture < 0.0f)
                depthOfField.aperture = 0.0f;
            if (depthOfField.focalLength < 0.0f)
                depthOfField.focalLength = 0.0f;
            depthOfField = _profile.depthOfField.settings;
            if (_profile2.depthOfField.enabled == true)
                _profile.depthOfField.enabled = _profile2.depthOfField.enabled;

            if (_profile.depthOfField.enabled == true && _profile2.depthOfField.enabled == true)
            {
                depthOfField.useCameraFov = _profile2.depthOfField.settings.useCameraFov;
                depthOfField.kernelSize = _profile2.depthOfField.settings.kernelSize;
                if (depthOfField.focusDistance != _profile2.depthOfField.settings.focusDistance)
                {
                    if (depthOfField.focusDistance > _profile2.depthOfField.settings.focusDistance)
                    {
                        depthOfField.focusDistance -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 10 * depthOfFieldSpeed;
                    }
                    else
                    {
                        depthOfField.focusDistance += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 10 * depthOfFieldSpeed;
                    }
                }
                if (depthOfField.aperture != _profile2.depthOfField.settings.aperture)
                {
                    if (depthOfField.aperture > _profile2.depthOfField.settings.aperture)
                    {
                        depthOfField.aperture -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * depthOfFieldSpeed;
                    }
                    else
                    {
                        depthOfField.aperture += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * depthOfFieldSpeed;
                    }
                }
                if (depthOfField.focalLength != _profile2.depthOfField.settings.focalLength)
                {
                    if (depthOfField.focalLength > _profile2.depthOfField.settings.focalLength)
                    {
                        depthOfField.focalLength -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 5 * depthOfFieldSpeed;
                    }
                    else
                    {
                        depthOfField.focalLength += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 5 * depthOfFieldSpeed;
                    }
                }

                _profile.depthOfField.settings = depthOfField;
            }

            #endregion

            #region Motion Blur
            if ((motionBlurChange == false && _profile2.motionBlur.enabled == false) || _profile.motionBlur.enabled == false)
            {
                motionBlur.shutterAngle = 0.0f;
                _profile.motionBlur.settings = motionBlur;
            }
            motionBlurChange = true;
            if (_profile2.motionBlur.enabled == false && motionBlurChange == true)
            {
                if (motionBlur.shutterAngle > 0)
                {
                    motionBlur.shutterAngle -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 40 * motionBlurSpeed;
                }
                else
                {
                    motionBlur.shutterAngle = 0;
                }
                _profile.motionBlur.settings = motionBlur;
            }
            if ((motionBlur.shutterAngle <= 0 && motionBlurChange == true) || (_profile2.motionBlur.enabled == false && _profile.motionBlur.enabled == false))
            {
                motionBlur.shutterAngle = 0.0f;
                motionBlur.sampleCount = _profile2.motionBlur.settings.sampleCount;
                motionBlur.frameBlending = _profile2.motionBlur.settings.frameBlending;
                _profile.motionBlur.settings = motionBlur;
                _profile.motionBlur.enabled = false;
                motionBlurChange = false;
            }
            motionBlur = _profile.motionBlur.settings;
            if (_profile2.motionBlur.enabled == true)
                _profile.motionBlur.enabled = _profile2.motionBlur.enabled;
            if (_profile.motionBlur.enabled == true && _profile2.motionBlur.enabled == true)
            {
                if (motionBlur.shutterAngle != _profile2.motionBlur.settings.shutterAngle)
                {
                    if (motionBlur.shutterAngle > _profile2.motionBlur.settings.shutterAngle)
                    {
                        motionBlur.shutterAngle -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 20 * motionBlurSpeed;
                    }
                    else
                    {
                        motionBlur.shutterAngle += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 20 * motionBlurSpeed;
                    }
                }
                if (motionBlur.frameBlending != _profile2.motionBlur.settings.frameBlending)
                {
                    if (motionBlur.frameBlending > _profile2.motionBlur.settings.frameBlending)
                    {
                        motionBlur.frameBlending -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * motionBlurSpeed;
                    }
                    else
                    {
                        motionBlur.frameBlending += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * motionBlurSpeed;
                    }
                }
                motionBlur.sampleCount = _profile2.motionBlur.settings.sampleCount;
                _profile.motionBlur.settings = motionBlur;
            }
            #endregion

            #region Eye Adaptation
            _profile.eyeAdaptation.enabled = _profile2.eyeAdaptation.enabled;
            eyeAdaptation = _profile2.eyeAdaptation.settings;
            _profile.eyeAdaptation.settings = eyeAdaptation;

            #endregion

            #region Bloom
            if ((bloomChange == false && _profile2.bloom.enabled == false) || _profile.bloom.enabled == false)
            {
                bloom.bloom.intensity = 0.0f;
                _profile.bloom.settings = bloom;
            }
            bloomChange = true;
            if (_profile2.bloom.enabled == false && bloomChange == true)
            {
                if (bloom.bloom.intensity > 0)
                {
                    bloom.bloom.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.5f * bloomSpeed;
                }
                else
                {
                    bloom.bloom.intensity = 0;
                }
                if (bloom.lensDirt.intensity > 0)
                {
                    bloom.lensDirt.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * bloomSpeed;
                }
                else
                {
                    bloom.lensDirt.intensity = 0;
                }
            }
            _profile.bloom.settings = bloom;


            if (bloom.bloom.intensity < 0 || (_profile2.bloom.enabled == false && _profile.bloom.enabled == false))
            {
                bloom.bloom.intensity = 0.0f;
                bloom.bloom.threshold = 0.0f;
                bloom.bloom.softKnee = 0.0f;
                bloom.bloom.radius = 0.0f;
                bloom.lensDirt.intensity = 0.0f;
                bloom.bloom.antiFlicker = _profile2.bloom.settings.bloom.antiFlicker;
                bloom.lensDirt.texture = _profile2.bloom.settings.lensDirt.texture;
                _profile.bloom.settings = bloom;
                _profile.bloom.enabled = false;
                bloomChange = false;
            }
            bloom = _profile.bloom.settings;
            if (_profile2.bloom.enabled == true)
                _profile.bloom.enabled = _profile2.bloom.enabled;

            if (_profile.bloom.enabled == true && _profile2.bloom.enabled == true)
            {
                bloom.bloom.antiFlicker = _profile2.bloom.settings.bloom.antiFlicker;
                bloom.lensDirt.texture = _profile2.bloom.settings.lensDirt.texture;
                if (bloom.bloom.intensity != _profile2.bloom.settings.bloom.intensity)
                {
                    if (bloom.bloom.intensity > _profile2.bloom.settings.bloom.intensity)
                    {
                        bloom.bloom.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.5f * bloomSpeed;
                    }
                    else
                    {
                        bloom.bloom.intensity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.5f * bloomSpeed;
                    }
                }
                bloom.bloom.threshold = _profile2.bloom.settings.bloom.threshold;

                bloom.bloom.softKnee = _profile2.bloom.settings.bloom.softKnee;

                bloom.bloom.radius = _profile2.bloom.settings.bloom.radius;

                if (bloom.lensDirt.intensity != _profile2.bloom.settings.lensDirt.intensity)
                {
                    if (bloom.lensDirt.intensity > _profile2.bloom.settings.lensDirt.intensity)
                    {
                        bloom.lensDirt.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.5f * bloomSpeed;
                    }
                    else
                    {
                        bloom.lensDirt.intensity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.5f * bloomSpeed;
                    }
                }

                _profile.bloom.settings = bloom;
            }
            #endregion

            #region Color Grading
            if ((colorGradingChange == false && _profile2.colorGrading.enabled == false) || _profile.colorGrading.enabled == false)
            {
                colorGrading.basic.postExposure = 0.0f;
                _profile.colorGrading.settings = colorGrading;
            }
            colorGradingChange = true;
            if (_profile2.colorGrading.enabled == false && colorGradingChange == true)
            {
                if (colorGrading.basic.postExposure > 0)
                {
                    colorGrading.basic.postExposure -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * colorGradingSpeed;
                }
                else
                {
                    colorGrading.basic.postExposure = 0;
                }
            }
            _profile.colorGrading.settings = colorGrading;

            if (colorGrading.basic.postExposure < 0 || (_profile2.colorGrading.enabled == false && _profile.colorGrading.enabled == false))
            {
                colorGrading.basic.postExposure = 0.0f;
                _profile.colorGrading.enabled = _profile2.colorGrading.enabled;
                _profile.colorGrading.settings = colorGrading;
                _profile.colorGrading.enabled = false;
                colorGradingChange = false;
            }
            colorGrading = _profile.colorGrading.settings;
            if (_profile2.colorGrading.enabled == true)
                _profile.colorGrading.enabled = _profile2.colorGrading.enabled;
            if (_profile.colorGrading.enabled == true && _profile2.colorGrading.enabled == true)
            {
                colorGrading.tonemapping = _profile2.colorGrading.settings.tonemapping;
                colorGrading.basic.temperature = _profile2.colorGrading.settings.basic.temperature;
                colorGrading.basic.tint = _profile2.colorGrading.settings.basic.tint;
                colorGrading.basic.hueShift = _profile2.colorGrading.settings.basic.hueShift;
                colorGrading.basic.saturation = _profile2.colorGrading.settings.basic.saturation;
                colorGrading.basic.contrast = _profile2.colorGrading.settings.basic.contrast;
                colorGrading.channelMixer = _profile2.colorGrading.settings.channelMixer;
                colorGrading.colorWheels = _profile2.colorGrading.settings.colorWheels;
                colorGrading.curves = _profile2.colorGrading.settings.curves;
                if (colorGrading.basic.postExposure != _profile2.colorGrading.settings.basic.postExposure)
                {
                    if (colorGrading.basic.postExposure > _profile2.colorGrading.settings.basic.postExposure)
                    {
                        colorGrading.basic.postExposure -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * colorGradingSpeed;
                    }
                    else
                    {
                        colorGrading.basic.postExposure += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * colorGradingSpeed;
                    }
                }
                _profile.colorGrading.settings = colorGrading;
            }
            #endregion

            #region User Lut
            if ((userLutChange == false && _profile2.userLut.enabled == false) || _profile.userLut.enabled == false)
            {
                userLut.contribution = 0.0f;
                _profile.userLut.settings = userLut;
            }
            userLutChange = true;
            if (_profile2.userLut.enabled == false && userLutChange == true)
            {
                if (userLut.contribution > 0)
                {
                    userLut.contribution -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.1f * userLutSpeed;
                }
                else
                {
                    userLut.contribution = 0;
                }
            }
            _profile.userLut.settings = userLut;

            if ((userLut.contribution < 0) || (_profile2.userLut.enabled == false && _profile.userLut.enabled == false))
            {
                userLut.contribution = 0.0f;
                userLut.lut = _profile2.userLut.settings.lut;
                _profile.userLut.settings = userLut;
                _profile.userLut.enabled = false;
                userLutChange = false;
            }

            userLut = _profile.userLut.settings;
            if (_profile2.userLut.enabled == true)
                _profile.userLut.enabled = _profile2.userLut.enabled;
            if (_profile.userLut.enabled == true && _profile2.userLut.enabled == true)
            {
                userLut.lut = _profile2.userLut.settings.lut;
                if (userLut.contribution != _profile2.userLut.settings.contribution)
                {
                    if (userLut.contribution > _profile2.userLut.settings.contribution)
                    {
                        userLut.contribution -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.1f * userLutSpeed;
                    }
                    else
                    {
                        userLut.contribution += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * 0.1f * userLutSpeed;
                    }
                }
                _profile.userLut.settings = userLut;
            }
            #endregion

            #region Chromatic Aberration
            if ((chromaticAberrationChange == false && _profile2.chromaticAberration.enabled == false) || _profile.chromaticAberration.enabled == false)
            {
                chromaticAberration.intensity = 0.0f;
                _profile.chromaticAberration.settings = chromaticAberration;
            }
            chromaticAberrationChange = true;
            if (_profile2.chromaticAberration.enabled == false && chromaticAberrationChange == true)
            {
                if (chromaticAberration.intensity > 0)
                {
                    chromaticAberration.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * chromaticAberrationSpeed;
                }
                else
                {
                    chromaticAberration.intensity = 0;
                }

            }
            _profile.chromaticAberration.settings = chromaticAberration;

            if ((chromaticAberration.intensity < 0) || (_profile2.chromaticAberration.enabled == false && _profile.chromaticAberration.enabled == false))
            {
                chromaticAberration.intensity = 0.0f;
                chromaticAberration.spectralTexture = _profile2.chromaticAberration.settings.spectralTexture;
                _profile.chromaticAberration.settings = chromaticAberration;
                _profile.chromaticAberration.enabled = false;
                chromaticAberrationChange = false;
            }

            chromaticAberration = _profile.chromaticAberration.settings;
            if (_profile2.chromaticAberration.enabled == true)
            {
                _profile.chromaticAberration.enabled = _profile2.chromaticAberration.enabled;
            }
            if (_profile.chromaticAberration.enabled == true && _profile2.chromaticAberration.enabled == true)
            {
                chromaticAberration.spectralTexture = _profile2.chromaticAberration.settings.spectralTexture;
                if (chromaticAberration.intensity != _profile2.chromaticAberration.settings.intensity)
                {
                    if (chromaticAberration.intensity > _profile2.chromaticAberration.settings.intensity)
                    {
                        chromaticAberration.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * chromaticAberrationSpeed;
                    }
                    else
                    {
                        chromaticAberration.intensity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * chromaticAberrationSpeed;
                    }
                }
                _profile.chromaticAberration.settings = chromaticAberration;
            }
            #endregion

            #region Grain

            if (grainChange == false && _profile2.grain.enabled == false || _profile.grain.enabled == false)
            {
                grain.intensity = 0.0f;
                grain.size = 0.0f;
                grain.luminanceContribution = 0.0f;
                _profile.grain.settings = grain;
            }
            grainChange = true;
            if (_profile2.grain.enabled == false && grainChange == true)
            {
                if (grain.intensity > 0)
                {
                    grain.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                }
                else
                {
                    grain.intensity = 0;
                }
                if (grain.size > 0)
                {
                    grain.size -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                }
                else
                {
                    grain.size = 0;
                }
                if (grain.luminanceContribution > 0)
                {
                    grain.luminanceContribution -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                }
                else
                {
                    grain.luminanceContribution = 0;
                }
            }
            _profile.grain.settings = grain;

            if ((grain.intensity < 0 && grain.size < 0 && grain.luminanceContribution < 0) || (_profile2.grain.enabled == false && _profile.grain.enabled == false))
            {
                grain.intensity = 0.0f;
                grain.size = 0.0f;
                grain.luminanceContribution = 0.0f;
                grain.colored = _profile2.grain.settings.colored;
                _profile.grain.settings = grain;
                _profile.grain.enabled = false;
                grainChange = false;
            }

            grain = _profile.grain.settings;
            if (_profile2.grain.enabled == true)
            {
                _profile.grain.enabled = _profile2.grain.enabled;
            }

            if (_profile.grain.enabled == true && _profile2.grain.enabled == true)
            {
                grain.colored = _profile2.grain.settings.colored;
                if (grain.intensity != _profile2.grain.settings.intensity)
                {
                    if (grain.intensity > _profile2.grain.settings.intensity)
                    {
                        grain.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                    }
                    else
                    {
                        grain.intensity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                    }
                }
                //grain.intensity = _profile2.grain.settings.intensity;
                if (grain.size != _profile2.grain.settings.size)
                {
                    if (grain.size > _profile2.grain.settings.size)
                    {
                        grain.size -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                    }
                    else
                    {
                        grain.size += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                    }
                }
                //grain.size = _profile2.grain.settings.size;
                if (grain.luminanceContribution != _profile2.grain.settings.luminanceContribution)
                {
                    if (grain.luminanceContribution > _profile2.grain.settings.luminanceContribution)
                    {
                        grain.luminanceContribution -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                    }
                    else
                    {
                        grain.luminanceContribution += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * grainSpeed;
                    }
                }
                _profile.grain.settings = grain;

            }
            #endregion

            #region Vignette
            if (vignetteChange == false && _profile2.vignette.enabled == false || _profile.vignette.enabled == false)
            {
                vignette.intensity = 0.0f;
                vignette.smoothness = 0.0f;
                vignette.roundness = 0.0f;
                vignette.opacity = 0.0f;
                vignette.mode = _profile2.vignette.settings.mode;
                vignette.color = _profile2.vignette.settings.color;
                vignette.center = _profile2.vignette.settings.center;
                vignette.mask = _profile2.vignette.settings.mask;
                _profile.vignette.settings = vignette;
            }
            vignetteChange = true;
            if (_profile2.vignette.enabled == false && vignetteChange == true)
            {
                if (vignette.intensity > 0)
                {
                    vignette.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                }
                else
                {
                    vignette.intensity = 0;
                }
                if (vignette.intensity > 0)
                {
                    vignette.smoothness -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                }
                else
                {
                    vignette.smoothness = 0;
                }
                if (vignette.intensity > 0)
                {
                    vignette.roundness -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                }
                else
                {
                    vignette.roundness = 0;
                }
                if (vignette.intensity > 0)
                {
                    vignette.opacity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                }
                else
                {
                    vignette.opacity = 0;
                }
            }

            _profile.vignette.settings = vignette;

            if (vignette.intensity < 0 || (_profile2.vignette.enabled == false && _profile.vignette.enabled == false))
            {
                vignette.intensity = 0.0f;
                vignette.smoothness = 0.0f;
                vignette.roundness = 0.0f;
                vignette.opacity = 0.0f;
                vignette.mode = _profile2.vignette.settings.mode;
                vignette.color = _profile2.vignette.settings.color;
                vignette.center = _profile2.vignette.settings.center;
                vignette.mask = _profile2.vignette.settings.mask;
                _profile.vignette.settings = vignette;
                _profile.vignette.enabled = false;
                vignetteChange = false;
            }

            vignette = _profile.vignette.settings;
            if (_profile2.vignette.enabled == true)
            {
                _profile.vignette.enabled = _profile2.vignette.enabled;
            }
            if (_profile.vignette.enabled == true && _profile2.vignette.enabled == true)
            {
                vignette.mode = _profile2.vignette.settings.mode;
                vignette.color = _profile2.vignette.settings.color;
                vignette.center = _profile2.vignette.settings.center;
                vignette.mask = _profile2.vignette.settings.mask;
                if (vignette.intensity != _profile2.vignette.settings.intensity)
                {
                    if (vignette.intensity > _profile2.vignette.settings.intensity)
                    {
                        vignette.intensity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    else
                    {
                        vignette.intensity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    if (vignette.smoothness > _profile2.vignette.settings.smoothness)
                    {
                        vignette.smoothness -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    else
                    {
                        vignette.smoothness += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    if (vignette.roundness > _profile2.vignette.settings.roundness)
                    {
                        vignette.roundness -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    else
                    {
                        vignette.roundness += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    if (vignette.opacity > _profile2.vignette.settings.opacity)
                    {
                        vignette.opacity -= (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                    else
                    {
                        vignette.opacity += (Mathf.Abs(Mathf.Sin(Time.realtimeSinceStartup) * 0.99f) + 0.1f) * speed * Time.deltaTime * vignetteSpeed;
                    }
                }
                _profile.vignette.settings = vignette;
            }
            #endregion

            //Dithering

            //Monitors
        }
        void Update()
        {
            if (!testchange1)
            {
                ProfileChange();
            }

            if (Input.GetKey(Blackout))
            {
                testchange1 = false;
            }

            #region Obsolete
            //if (controlAntialiasing)
            //    {
            //        if (enableAntialiasing != _profile.antialiasing.enabled)
            //            _profile.antialiasing.enabled = enableAntialiasing;

            //        if (enableAntialiasing)
            //            _profile.antialiasing.settings = antialiasing;
            //    }

            //    if (controlAmbientOcclusion)
            //    {
            //        if (enableAmbientOcclusion != _profile.ambientOcclusion.enabled)
            //            _profile.ambientOcclusion.enabled = enableAmbientOcclusion;

            //        if (enableAmbientOcclusion)
            //            _profile.ambientOcclusion.settings = ambientOcclusion;
            //    }

            //    if (controlScreenSpaceReflection)
            //    {
            //        if (enableScreenSpaceReflection != _profile.screenSpaceReflection.enabled)
            //            _profile.screenSpaceReflection.enabled = enableScreenSpaceReflection;

            //        if (enableScreenSpaceReflection)
            //            _profile.screenSpaceReflection.settings = screenSpaceReflection;
            //    }

            //    if (controlDepthOfField)
            //    {
            //        if (enableDepthOfField != _profile.depthOfField.enabled)
            //            _profile.depthOfField.enabled = enableDepthOfField;

            //        if (enableDepthOfField)
            //            _profile.depthOfField.settings = depthOfField;
            //    }

            //    if (controlMotionBlur)
            //    {
            //        if (enableMotionBlur != _profile.motionBlur.enabled)
            //            _profile.motionBlur.enabled = enableMotionBlur;

            //        if (enableMotionBlur)
            //            _profile.motionBlur.settings = motionBlur;
            //    }

            //    if (controlEyeAdaptation)
            //    {
            //        if (enableEyeAdaptation != _profile.eyeAdaptation.enabled)
            //            _profile.eyeAdaptation.enabled = enableEyeAdaptation;

            //        if (enableEyeAdaptation)
            //            _profile.eyeAdaptation.settings = eyeAdaptation;
            //    }

            //    if (controlBloom)
            //    {
            //        if (enableBloom != _profile.bloom.enabled)
            //            _profile.bloom.enabled = enableBloom;

            //        if (enableBloom)
            //            _profile.bloom.settings = bloom;
            //    }

            //    if (controlColorGrading)
            //    {
            //        if (enableColorGrading != _profile.colorGrading.enabled)
            //            _profile.colorGrading.enabled = enableColorGrading;

            //        if (enableColorGrading)
            //            _profile.colorGrading.settings = colorGrading;
            //    }

            //    if (controlUserLut)
            //    {
            //        if (enableUserLut != _profile.userLut.enabled)
            //            _profile.userLut.enabled = enableUserLut;

            //        if (enableUserLut)
            //            _profile.userLut.settings = userLut;
            //    }

            //    if (controlChromaticAberration)
            //    {
            //        if (enableChromaticAberration != _profile.chromaticAberration.enabled)
            //            _profile.chromaticAberration.enabled = enableChromaticAberration;

            //        if (enableChromaticAberration)
            //            _profile.chromaticAberration.settings = chromaticAberration;
            //    }

            //    if (controlGrain)
            //    {
            //        if (enableGrain != _profile.grain.enabled)
            //            _profile.grain.enabled = enableGrain;

            //        if (enableGrain)
            //            _profile.grain.settings = grain;
            //    }

            //    if (controlVignette)
            //    {
            //        if (enableVignette != _profile.vignette.enabled)
            //            _profile.vignette.enabled = enableVignette;

            //        if (enableVignette)
            //            _profile.vignette.settings = vignette;
            //    }
            #endregion
        }

        #endregion

    }
}
