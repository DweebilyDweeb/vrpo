// Utility scripts for the post processing stack
// https://github.com/keijiro/PostProcessingUtilities

using UnityEngine;
using UnityEditor;

namespace UnityEngine.PostProcessing.Utilities
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(PostProcessingController))]
    public class PostProcessingControllerEditor : Editor
    {
        #region Public structs

        SerializedProperty _trigger;

        SerializedProperty _generalSpeed;

        SerializedProperty _antiAliasingSpeed;
        SerializedProperty _antiAliasing;
        public bool enableAntiAliasingChange;

        SerializedProperty _ambientOcclusionSpeed;
        SerializedProperty _ambientOcclusion;
        public bool enableAmbientOcclusionChange;

        SerializedProperty _screenSpaceReflectionSpeed;
        SerializedProperty _screenSpaceReflection;
        public bool enableScreenSpaceReflectionChange;

        SerializedProperty _depthOfFieldSpeed;
        SerializedProperty _depthOfField;
        public bool enableDepthOfFieldChange;

        SerializedProperty _motionBlurSpeed;
        SerializedProperty _motionBlur;
        public bool enableMotionBlurChange;

        SerializedProperty _eyeAdaptationSpeed;
        SerializedProperty _eyeAdaptation;
        public bool enableEyeAdaptationChange;

        SerializedProperty _bloomSpeed;
        SerializedProperty _bloom;
        public bool enableBloomChange;

        SerializedProperty _colorGradingSpeed;
        SerializedProperty _colorGrading;
        public bool enableColorGradingChange;

        SerializedProperty _userLutSpeed;
        SerializedProperty _userLut;
        public bool enableUserLutChange;

        SerializedProperty _chromaticAberrationSpeed;
        SerializedProperty _chromaticAberration;
        public bool enableChromaticAberrationChange;

        SerializedProperty _grainSpeed;
        SerializedProperty _grain;
        public bool enableGrainChange;

        SerializedProperty _vignetteSpeed;
        SerializedProperty _vignette;
        public bool enableVignetteChange;
        #endregion

        #region Text labels

        static GUIContent _textSpeed = new GUIContent("Speed");
        static GUIContent _textTrigger1 = new GUIContent("Trigger 1");
        static GUIContent _textSettings = new GUIContent("Settings");

        #endregion

        #region Editor functions

        void OnEnable()
        {
            _trigger = serializedObject.FindProperty("testchange1");

            _generalSpeed = serializedObject.FindProperty("speed");

            _antiAliasingSpeed = serializedObject.FindProperty("antiAliasingSpeed");
            _antiAliasing = serializedObject.FindProperty("antiAliasing");

            _ambientOcclusionSpeed = serializedObject.FindProperty("ambientOcclusionSpeed");
            _ambientOcclusion = serializedObject.FindProperty("ambientOcclusion");

            _screenSpaceReflectionSpeed = serializedObject.FindProperty("screenSpaceReflectionSpeed");
            _screenSpaceReflection = serializedObject.FindProperty("screenSpaceReflection");

            _depthOfFieldSpeed = serializedObject.FindProperty("depthOfFieldSpeed");
            _depthOfField = serializedObject.FindProperty("depthOfField");

            _motionBlurSpeed = serializedObject.FindProperty("motionBlurSpeed");
            _motionBlur = serializedObject.FindProperty("motionBlur");

            _eyeAdaptationSpeed = serializedObject.FindProperty("eyeAdaptationSpeed");
            _eyeAdaptation = serializedObject.FindProperty("eyeAdaptation");

            _bloomSpeed = serializedObject.FindProperty("bloomSpeed");
            _bloom = serializedObject.FindProperty("bloom");

            _colorGradingSpeed = serializedObject.FindProperty("colorGradingSpeed");
            _colorGrading = serializedObject.FindProperty("colorGrading");

            _userLutSpeed = serializedObject.FindProperty("userLutSpeed");
            _userLut = serializedObject.FindProperty("userLut");

            _chromaticAberrationSpeed = serializedObject.FindProperty("chromaticAberrationSpeed");
            _chromaticAberration = serializedObject.FindProperty("chromaticAberration");

            _grainSpeed = serializedObject.FindProperty("grainSpeed");
            _grain = serializedObject.FindProperty("grain");

            _vignetteSpeed = serializedObject.FindProperty("vignetteSpeed");
            _vignette = serializedObject.FindProperty("vignette");
        }

        public override void OnInspectorGUI()
        {
            var isPlaying = Application.isPlaying;

            serializedObject.Update();


            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Trigger", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_trigger, _textTrigger1);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("General Speed", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(_generalSpeed, _textSpeed);

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Anti Aliasing", EditorStyles.boldLabel, GUILayout.Width(300));
            enableAntiAliasingChange = EditorGUILayout.Toggle(enableAntiAliasingChange);
            GUILayout.EndHorizontal();

            if (enableAntiAliasingChange)
            {
                EditorGUILayout.PropertyField(_antiAliasingSpeed, _textSpeed);

            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Ambient Occlusion", EditorStyles.boldLabel, GUILayout.Width(300));
            enableAmbientOcclusionChange = EditorGUILayout.Toggle(enableAmbientOcclusionChange);
            GUILayout.EndHorizontal();

            if (enableAmbientOcclusionChange)
            {
                EditorGUILayout.PropertyField(_ambientOcclusionSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Screen Space Reflection", EditorStyles.boldLabel, GUILayout.Width(300));
            enableScreenSpaceReflectionChange = EditorGUILayout.Toggle(enableScreenSpaceReflectionChange);
            GUILayout.EndHorizontal();

            if (enableScreenSpaceReflectionChange)
            {
                EditorGUILayout.PropertyField(_screenSpaceReflectionSpeed, _textSpeed);
            }

            EditorGUILayout.Space();


            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Depth Of Field", EditorStyles.boldLabel, GUILayout.Width(300));
            enableDepthOfFieldChange = EditorGUILayout.Toggle(enableDepthOfFieldChange);
            GUILayout.EndHorizontal();

            if (enableDepthOfFieldChange)
            {
                EditorGUILayout.PropertyField(_depthOfFieldSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Anti Aliasing", EditorStyles.boldLabel, GUILayout.Width(300));
            enableMotionBlurChange = EditorGUILayout.Toggle(enableMotionBlurChange);
            GUILayout.EndHorizontal();

            if (enableMotionBlurChange)
            {
                EditorGUILayout.PropertyField(_motionBlurSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Eye Adaptation", EditorStyles.boldLabel, GUILayout.Width(300));
            enableEyeAdaptationChange = EditorGUILayout.Toggle(enableEyeAdaptationChange);
            GUILayout.EndHorizontal();

            if (enableEyeAdaptationChange)
            {
                EditorGUILayout.PropertyField(_eyeAdaptationSpeed, _textSpeed);

            }
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Bloom", EditorStyles.boldLabel, GUILayout.Width(300));
            enableBloomChange = EditorGUILayout.Toggle(enableBloomChange);
            GUILayout.EndHorizontal();

            if (enableBloomChange)
            {
                EditorGUILayout.PropertyField(_bloomSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Color Grading", EditorStyles.boldLabel, GUILayout.Width(300));
            enableColorGradingChange = EditorGUILayout.Toggle(enableColorGradingChange);
            GUILayout.EndHorizontal();

            if (enableColorGradingChange)
            {
                EditorGUILayout.PropertyField(_colorGradingSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("User Lut", EditorStyles.boldLabel, GUILayout.Width(300));
            enableUserLutChange = EditorGUILayout.Toggle(enableUserLutChange);
            GUILayout.EndHorizontal();

            if (enableUserLutChange)
            {
                EditorGUILayout.PropertyField(_userLutSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Chromatic Aberration", EditorStyles.boldLabel, GUILayout.Width(300));
            enableChromaticAberrationChange = EditorGUILayout.Toggle(enableChromaticAberrationChange);
            GUILayout.EndHorizontal();

            if (enableChromaticAberrationChange)
            {
                EditorGUILayout.PropertyField(_chromaticAberrationSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Grain", EditorStyles.boldLabel, GUILayout.Width(300));
            enableGrainChange = EditorGUILayout.Toggle(enableGrainChange);
            GUILayout.EndHorizontal();

            if (enableGrainChange)
            {
                EditorGUILayout.PropertyField(_grainSpeed, _textSpeed);
            }

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Vignette", EditorStyles.boldLabel, GUILayout.Width(300));
            enableVignetteChange = EditorGUILayout.Toggle(enableVignetteChange);
            GUILayout.EndHorizontal();

            if (enableVignetteChange)
            {
                EditorGUILayout.PropertyField(_vignetteSpeed, _textSpeed);
            }

            serializedObject.ApplyModifiedProperties();
        }

        #endregion
    }
}
