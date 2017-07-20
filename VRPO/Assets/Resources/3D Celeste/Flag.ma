//Maya ASCII 2016 scene
//Name: Flag.ma
//Last modified: Thu, Jul 20, 2017 10:58:46 AM
//Codeset: 1252
requires maya "2016";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Microsoft Windows 7 Enterprise Edition, 64-bit Windows 7 Service Pack 1 (Build 7601)\n";
fileInfo "license" "education";
createNode transform -s -n "persp";
	rename -uid "20993E46-48F8-9273-7949-28A47B1DFBD5";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.027140435655592435 3.5629480682926422 5.2801088715053126 ;
	setAttr ".r" -type "double3" -7.5383527295929227 -720.19999999993775 -3.7272352249325305e-017 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "08D1ADA4-402A-CE24-E3A7-948D57A53C1B";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 5.9042155208142884;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	rename -uid "65634125-4808-F8A2-9169-FE93A2B56643";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 100.1 0 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "47AD12A4-4C74-9B78-E8CD-BEA9A0A8BBB5";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
createNode transform -s -n "front";
	rename -uid "DD0CBAD3-42D0-5578-E6E6-249877C97D64";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 100.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "9615CE01-4127-F0CD-C909-BEA5794444DD";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
createNode transform -s -n "side";
	rename -uid "68163426-4038-FFD7-4770-39A23B053638";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 100.1 2.5414368906011915 -0.10335987354119625 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "132A0C03-41AA-EB29-90C1-45B38B01741D";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 8.6092694667255696;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
createNode transform -n "pCylinder1";
	rename -uid "19A7393B-486D-319C-73C0-00B7566FC542";
	setAttr ".t" -type "double3" 0.013650997710401958 1.7509270678000364 -0.0019211869157170491 ;
	setAttr ".rp" -type "double3" 0 -1.7518249050830945 0 ;
	setAttr ".sp" -type "double3" 0 -1.7518249050830945 0 ;
createNode mesh -n "pCylinderShape1" -p "pCylinder1";
	rename -uid "3D0ED807-401C-E104-669F-2B8A9AFEDD7D";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50418043716766481 0.93295321280126409 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".bw" 3;
	setAttr ".qsp" 0;
createNode transform -n "left";
	rename -uid "CBD15542-4F6F-EA7A-8894-33BA01E5E9FA";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -100.1 3.0089898101941928 0.14171286216944803 ;
	setAttr ".r" -type "double3" 0 -89.999999999999986 0 ;
createNode camera -n "leftShape" -p "left";
	rename -uid "D68666BD-47DE-69C5-9EFE-3BA4637150BA";
	setAttr -k off ".v";
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 4.7434853702993225;
	setAttr ".imn" -type "string" "left1";
	setAttr ".den" -type "string" "left1_depth";
	setAttr ".man" -type "string" "left1_mask";
	setAttr ".hc" -type "string" "viewSet -ls %camera";
	setAttr ".o" yes;
createNode transform -n "pPlane1";
	rename -uid "6F958A4B-4467-29A9-F409-2AA37061648E";
	setAttr ".t" -type "double3" 0.66395143567412951 3.073326823701366 -0.0026277096968714609 ;
	setAttr ".r" -type "double3" 90.146030608540343 0 0 ;
createNode mesh -n "pPlaneShape1" -p "pPlane1";
	rename -uid "3259557F-4C01-CE45-499C-B1992AF0B91E";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".bw" 3;
createNode mesh -n "outputCloth1" -p "pPlane1";
	rename -uid "7B8E6BF9-465C-3D14-567C-B9AD52EB7427";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50091769360005856 0.49950874596834183 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".bw" 3;
	setAttr ".qsp" 0;
createNode nucleus -n "nucleus1";
	rename -uid "EBEAB3E4-4489-BCDF-4CE3-B2AAA7D7D282";
	setAttr ".ena" no;
	setAttr ".wisp" 12;
	setAttr ".widi" -type "float3" 1 0 -1 ;
	setAttr ".wnoi" 0.25;
createNode transform -n "nCloth1";
	rename -uid "1E3544B8-4736-856E-3776-E284A0AE76B9";
	setAttr -l on ".t";
	setAttr -l on ".r";
	setAttr -l on ".s";
createNode nCloth -n "nClothShape1" -p "nCloth1";
	rename -uid "4389E488-4E2F-0024-4E4F-1F9149617028";
	addAttr -ci true -sn "nts" -ln "notes" -dt "string";
	addAttr -ci true -sn "lifespan" -ln "lifespan" -at "double";
	addAttr -s false -ci true -sn "lifespanPP" -ln "lifespanPP" -dt "doubleArray";
	addAttr -ci true -h true -sn "lifespanPP0" -ln "lifespanPP0" -dt "doubleArray";
	setAttr -k off ".v";
	setAttr ".gf" -type "Int32Array" 0 ;
	setAttr ".pos0" -type "vectorArray" 0 ;
	setAttr ".vel0" -type "vectorArray" 0 ;
	setAttr ".acc0" -type "vectorArray" 0 ;
	setAttr ".mas0" -type "doubleArray" 0 ;
	setAttr ".id0" -type "doubleArray" 0 ;
	setAttr ".bt0" -type "doubleArray" 0 ;
	setAttr ".ag0" -type "doubleArray" 0 ;
	setAttr -k off ".dve";
	setAttr -k off ".lfm";
	setAttr -k off ".lfr";
	setAttr -k off ".ead";
	setAttr ".irbx" -type "string" "";
	setAttr ".irax" -type "string" "";
	setAttr ".icx" -type "string" "";
	setAttr ".isd" no;
	setAttr -k off ".dw";
	setAttr -k off ".fiw";
	setAttr -k off ".con";
	setAttr -k off ".eiw";
	setAttr -k off ".mxc";
	setAttr -k off ".lod";
	setAttr -k off ".inh";
	setAttr ".cts" 200;
	setAttr -k off ".stf";
	setAttr -k off ".igs";
	setAttr -k off ".ecfh";
	setAttr -k off ".tgs";
	setAttr -k off ".gsm";
	setAttr -k off ".chd";
	setAttr ".chw" 200;
	setAttr -k off ".trd";
	setAttr -k off ".prt";
	setAttr ".thss" 0.0057990043424069881;
	setAttr ".fron" 0.05000000074505806;
	setAttr ".adng" 0.20000000298023224;
	setAttr ".pmss" 0.20000000298023224;
	setAttr ".por" 0.023196017369627953;
	setAttr ".lsou" yes;
	setAttr ".srl" 1;
	setAttr ".stch" 60;
	setAttr ".bnd" 0.05000000074505806;
	setAttr ".bnad" 0.30000001192092896;
	setAttr ".scws" 3;
	setAttr ".tdrg" 0.05000000074505806;
	setAttr ".nts" -type "string" "Silk is smooth, lightweight, flexible but non-stretchy. Its low mass causes air drag and wind to affect it more. The compression resistance is relatively low, which helps lower resolution meshes maintain flexibility. For very high resolution meshes one may consider increasing the compression resistance. Depending on the scene one may need to increase the substeps and/or collision iterations to avoid stretching on colliding elements. Also one may yet need to increase the stretch resistance further for high gravity or fast moving objects. If the material seems to springy try also increasing the damp value.";
	setAttr -k on ".lifespan" 1;
	setAttr ".lifespanPP0" -type "doubleArray" 0 ;
createNode transform -n "dynamicConstraint1";
	rename -uid "AAFFF6C4-418B-1CE1-8E81-62BF64FB9845";
	setAttr ".t" -type "double3" 0.063951411832271599 3.0733268386023687 -0.0026277096157642787 ;
createNode dynamicConstraint -n "dynamicConstraintShape1" -p "dynamicConstraint1";
	rename -uid "CD6DCBC2-48C7-BD25-373C-B4B581E864CA";
	setAttr -k off ".v";
	setAttr ".crr" 0;
	setAttr ".cdnr[0]"  0 0 0;
	setAttr ".sdp[0]"  0 0 0;
createNode transform -n "nRigid1";
	rename -uid "1371BE12-44EE-875E-F430-CEBC00F6F344";
	setAttr -l on ".t";
	setAttr -l on ".r";
	setAttr -l on ".s";
createNode nRigid -n "nRigidShape1" -p "nRigid1";
	rename -uid "28598042-4A7A-613D-A7FB-EFB5E8B1E42A";
	addAttr -ci true -sn "lifespan" -ln "lifespan" -at "double";
	addAttr -s false -ci true -sn "lifespanPP" -ln "lifespanPP" -dt "doubleArray";
	addAttr -ci true -h true -sn "lifespanPP0" -ln "lifespanPP0" -dt "doubleArray";
	setAttr -k off ".v";
	setAttr ".gf" -type "Int32Array" 0 ;
	setAttr ".pos0" -type "vectorArray" 0 ;
	setAttr ".vel0" -type "vectorArray" 0 ;
	setAttr ".acc0" -type "vectorArray" 0 ;
	setAttr ".mas0" -type "doubleArray" 0 ;
	setAttr ".id0" -type "doubleArray" 0 ;
	setAttr ".bt0" -type "doubleArray" 0 ;
	setAttr ".ag0" -type "doubleArray" 0 ;
	setAttr -k off ".dve";
	setAttr -k off ".lfm";
	setAttr -k off ".lfr";
	setAttr -k off ".ead";
	setAttr ".irbx" -type "string" "";
	setAttr ".irax" -type "string" "";
	setAttr ".icx" -type "string" "";
	setAttr -k off ".dw";
	setAttr -k off ".fiw";
	setAttr -k off ".con";
	setAttr -k off ".eiw";
	setAttr -k off ".mxc";
	setAttr -k off ".lod";
	setAttr -k off ".inh";
	setAttr ".cts" 200;
	setAttr -k off ".stf";
	setAttr -k off ".igs";
	setAttr -k off ".ecfh";
	setAttr -k off ".tgs";
	setAttr -k off ".gsm";
	setAttr -k off ".chd";
	setAttr ".chw" 200;
	setAttr -k off ".trd";
	setAttr -k off ".prt";
	setAttr ".thss" 0.0034513541031628847;
	setAttr ".actv" no;
	setAttr ".scld" no;
	setAttr ".por" 0.013805416412651539;
	setAttr ".tpc" yes;
	setAttr -s 2 ".fsc[0:1]"  0 1 1 1 0 1;
	setAttr -s 2 ".pfdo[0:1]"  0 1 1 1 0 1;
	setAttr -k on ".lifespan" 1;
	setAttr ".lifespanPP0" -type "doubleArray" 0 ;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "9A1F6690-4EEC-B7BD-0A2E-F79A789EA4D7";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode displayLayerManager -n "layerManager";
	rename -uid "92B24BE3-41CD-5197-0C2B-6AAF30011C9B";
createNode displayLayer -n "defaultLayer";
	rename -uid "549C1452-4502-98EE-0A42-D8BFE613551C";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "F00E9766-45A3-6AF7-4835-889AFA62AE64";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "1A291EEC-457F-863A-7595-02B1405F096D";
	setAttr ".g" yes;
createNode polyCylinder -n "polyCylinder1";
	rename -uid "6155EAB9-4721-F286-5D5A-C882824FF159";
	setAttr ".r" 0.05;
	setAttr ".h" 3.5;
	setAttr ".sa" 6;
	setAttr ".cuv" 3;
createNode polyPlane -n "polyPlane1";
	rename -uid "6A5190F9-483D-4AB1-61DB-34BE5F0D4E4C";
	setAttr ".w" 1.2;
	setAttr ".h" 0.74312883423292797;
	setAttr ".sw" 30;
	setAttr ".sh" 30;
	setAttr ".cuv" 2;
createNode nComponent -n "nComponent1";
	rename -uid "86B4B38E-4AD6-A1C0-EE5D-6585A00E3104";
	setAttr ".ct" 2;
	setAttr -s 31 ".ci[0:30]"  0 31 62 93 124 155 
		186 217 248 279 310 341 372 403 434 465 496 527 
		558 589 620 651 682 713 744 775 806 837 868 899 
		930;
createNode script -n "uiConfigurationScriptNode";
	rename -uid "566D6046-4CE6-2D5E-D501-40A2C0EF06FD";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"top\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n"
		+ "                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n"
		+ "                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n"
		+ "                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 1\n                -height 1\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n"
		+ "                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n"
		+ "            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n"
		+ "            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n"
		+ "        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"side\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n"
		+ "                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n"
		+ "                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n"
		+ "                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 1\n                -height 1\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n"
		+ "            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n"
		+ "            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n"
		+ "            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels `;\n"
		+ "\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"front\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n"
		+ "                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n"
		+ "                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n"
		+ "                -width 1\n                -height 1\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n"
		+ "            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n"
		+ "            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n"
		+ "            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"persp\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n"
		+ "                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n"
		+ "                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n"
		+ "                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 1615\n                -height 788\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n"
		+ "\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n"
		+ "            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n"
		+ "            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1615\n            -height 788\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n"
		+ "            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `outlinerPanel -unParent -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            outlinerEditor -e \n                -showShapes 0\n                -showReferenceNodes 1\n                -showReferenceMembers 1\n                -showAttributes 0\n                -showConnected 0\n                -showAnimCurvesOnly 0\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 1\n                -showAssets 1\n                -showContainedOnly 1\n                -showPublishedAsConnected 0\n                -showContainerContents 1\n                -ignoreDagHierarchy 0\n                -expandConnections 0\n"
		+ "                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 0\n                -highlightActive 1\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"defaultSetFilter\" \n                -showSetMembers 1\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n"
		+ "                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 0\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n"
		+ "            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n"
		+ "            -ignoreOutlinerColor 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"graphEditor\" -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n"
		+ "                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n"
		+ "                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n"
		+ "                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n"
		+ "                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n"
		+ "                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n"
		+ "                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dopeSheetPanel\" -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n"
		+ "                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n"
		+ "                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n"
		+ "                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n"
		+ "\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"clipEditorPanel\" -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n"
		+ "            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -frameRange -344.839129 466.839129 \n                -manageSequencer 0 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -frameRange -344.839129 466.839129 \n                -manageSequencer 0 \n"
		+ "                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\tif ($useSceneConfig) {\n\t\tscriptedPanel -e -to $panelName;\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"sequenceEditorPanel\" -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"hyperGraphPanel\" -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n"
		+ "                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n"
		+ "                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"visorPanel\" -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"createNodePanel\" -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"polyTexturePlacementPanel\" -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"renderWindowPanel\" -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"blendShapePanel\" (localizedPanelLabel(\"Blend Shape\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\tblendShapePanel -unParent -l (localizedPanelLabel(\"Blend Shape\")) -mbv $menusOkayInPanels ;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tblendShapePanel -edit -l (localizedPanelLabel(\"Blend Shape\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dynRelEdPanel\" -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"relationshipPanel\" -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"referenceEditorPanel\" -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"componentEditorPanel\" -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dynPaintScriptedPanelType\" -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"scriptEditorPanel\" -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"profilerPanel\" -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"hyperShadePanel\" -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n"
		+ "                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -activeTab -1\n                -editorMode \"default\" \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n"
		+ "                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -activeTab -1\n                -editorMode \"default\" \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n"
		+ "        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-defaultImage \"\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 16384\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1615\\n    -height 788\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 16384\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1615\\n    -height 788\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        setFocus `paneLayout -q -p1 $gMainPane`;\n        sceneUIReplacement -deleteRemaining;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "6286AD9B-4251-FD75-6990-C49D09D1FABF";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 200 -ast 1 -aet 200 ";
	setAttr ".st" 6;
createNode polyMapSewMove -n "polyMapSewMove1";
	rename -uid "1C4F4EE8-4475-0E20-4F9F-62AA7FA23781";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[9]";
createNode polyMapSewMove -n "polyMapSewMove2";
	rename -uid "468AC790-4505-132B-615D-0AA6172E93FC";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "e[3]";
createNode polyTweakUV -n "polyTweakUV1";
	rename -uid "B3989585-48C4-11AB-25E4-E58BB0E3D24B";
	setAttr ".uopa" yes;
	setAttr -s 22 ".uvtk[0:21]" -type "float2" -0.006572783 0.13047454 0.096538454
		 0.1571565 0.17120725 0.081204727 0.11410046 -0.02143389 0.021679461 -0.020673305
		 -0.034196615 0.08262755 0.19547629 -0.023689061 0.15880248 -0.022937715 0.12212861
		 -0.022185326 0.013651848 -0.019899786 -0.023021519 -0.019125909 0.14285672 -0.050122023
		 0.10618284 -0.049367368 0.069509029 -0.048612833 0.06148082 -0.04785347 -0.032494187
		 -0.047090352 -0.040522635 -0.046319723 -0.077196062 -0.045547724 0.16533691 -0.17953724
		 0.088939875 -0.31044424 -0.062600255 -0.30968314 -0.13766766 -0.17800397;
createNode polyTweakUV -n "polyTweakUV2";
	rename -uid "3B8C82B9-446C-326E-A1C5-87BCD13DEF35";
	setAttr ".uopa" yes;
	setAttr -s 961 ".uvtk";
	setAttr ".uvtk[0:249]" -type "float2" 0.014352422 0.19819166 0.013456859
		 0.19819166 0.012561116 0.19819166 0.011665519 0.19819166 0.010769788 0.19819166 0.0098742284
		 0.19819166 0.0089785261 0.19819166 0.0080828769 0.19819166 0.0071872426 0.19819166
		 0.0062915636 0.19819166 0.0053959144 0.19819166 0.0045002354 0.19819166 0.0036045415
		 0.19819166 0.0027088923 0.19819166 0.0018132357 0.19819166 0.0009175567 0.19819166
		 2.1967106e-005 0.19819166 -0.0008737715 0.19819166 -0.0017694207 0.19819166 -0.0026650997
		 0.19819166 -0.0035606008 0.19819166 -0.0044563692 0.19819166 -0.0053520184 0.19819166
		 -0.0062476676 0.19819166 -0.0071433764 0.19819166 -0.0080388766 0.19819166 -0.0089346748
		 0.19819166 -0.0098304208 0.19819166 -0.010726055 0.19819166 -0.011621496 0.19819166
		 -0.012517055 0.19819166 0.014352422 0.19763704 0.013456859 0.19763704 0.012561116
		 0.19763704 0.011665519 0.19763704 0.010769788 0.19763704 0.0098742284 0.19763704
		 0.0089785261 0.19763704 0.0080828769 0.19763704 0.0071872426 0.19763704 0.0062915636
		 0.19763704 0.0053959144 0.19763704 0.0045002354 0.19763704 0.0036045415 0.19763704
		 0.0027088923 0.19763704 0.0018132357 0.19763704 0.0009175567 0.19763704 2.1967106e-005
		 0.19763704 -0.0008737715 0.19763704 -0.0017694207 0.19763704 -0.0026650997 0.19763704
		 -0.0035606008 0.19763704 -0.0044563692 0.19763704 -0.0053520184 0.19763704 -0.0062476676
		 0.19763704 -0.0071433764 0.19763704 -0.0080388766 0.19763704 -0.0089346748 0.19763704
		 -0.0098304208 0.19763704 -0.010726055 0.19763704 -0.011621496 0.19763704 -0.012517055
		 0.19763704 0.014352422 0.19708231 0.013456859 0.19708231 0.012561116 0.19708231 0.011665519
		 0.19708231 0.010769788 0.19708231 0.0098742284 0.19708231 0.0089785261 0.19708231
		 0.0080828769 0.19708231 0.0071872426 0.19708231 0.0062915636 0.19708231 0.0053959144
		 0.19708231 0.0045002354 0.19708231 0.0036045415 0.19708231 0.0027088923 0.19708231
		 0.0018132357 0.19708231 0.0009175567 0.19708231 2.1967106e-005 0.19708231 -0.0008737715
		 0.19708231 -0.0017694207 0.19708231 -0.0026650997 0.19708231 -0.0035606008 0.19708231
		 -0.0044563692 0.19708231 -0.0053520184 0.19708231 -0.0062476676 0.19708231 -0.0071433764
		 0.19708231 -0.0080388766 0.19708231 -0.0089346748 0.19708231 -0.0098304208 0.19708231
		 -0.010726055 0.19708231 -0.011621496 0.19708231 -0.012517055 0.19708231 0.014352422
		 0.19652762 0.013456859 0.19652762 0.012561116 0.19652762 0.011665519 0.19652762 0.010769788
		 0.19652762 0.0098742284 0.19652762 0.0089785261 0.19652762 0.0080828769 0.19652762
		 0.0071872426 0.19652762 0.0062915636 0.19652762 0.0053959144 0.19652762 0.0045002354
		 0.19652762 0.0036045415 0.19652762 0.0027088923 0.19652762 0.0018132357 0.19652762
		 0.0009175567 0.19652762 2.1967106e-005 0.19652762 -0.0008737715 0.19652762 -0.0017694207
		 0.19652762 -0.0026650997 0.19652762 -0.0035606008 0.19652762 -0.0044563692 0.19652762
		 -0.0053520184 0.19652762 -0.0062476676 0.19652762 -0.0071433764 0.19652762 -0.0080388766
		 0.19652762 -0.0089346748 0.19652762 -0.0098304208 0.19652762 -0.010726055 0.19652762
		 -0.011621496 0.19652762 -0.012517055 0.19652762 0.014352422 0.19597299 0.013456859
		 0.19597299 0.012561116 0.19597299 0.011665519 0.19597299 0.010769788 0.19597299 0.0098742284
		 0.19597299 0.0089785261 0.19597299 0.0080828769 0.19597299 0.0071872426 0.19597299
		 0.0062915636 0.19597299 0.0053959144 0.19597299 0.0045002354 0.19597299 0.0036045415
		 0.19597299 0.0027088923 0.19597299 0.0018132357 0.19597299 0.0009175567 0.19597299
		 2.1967106e-005 0.19597299 -0.0008737715 0.19597299 -0.0017694207 0.19597299 -0.0026650997
		 0.19597299 -0.0035606008 0.19597299 -0.0044563692 0.19597299 -0.0053520184 0.19597299
		 -0.0062476676 0.19597299 -0.0071433764 0.19597299 -0.0080388766 0.19597299 -0.0089346748
		 0.19597299 -0.0098304208 0.19597299 -0.010726055 0.19597299 -0.011621496 0.19597299
		 -0.012517055 0.19597299 0.014352422 0.19541831 0.013456859 0.19541831 0.012561116
		 0.19541831 0.011665519 0.19541831 0.010769788 0.19541831 0.0098742284 0.19541831
		 0.0089785261 0.19541831 0.0080828769 0.19541831 0.0071872426 0.19541831 0.0062915636
		 0.19541831 0.0053959144 0.19541831 0.0045002354 0.19541831 0.0036045415 0.19541831
		 0.0027088923 0.19541831 0.0018132357 0.19541831 0.0009175567 0.19541831 2.1967106e-005
		 0.19541831 -0.0008737715 0.19541831 -0.0017694207 0.19541831 -0.0026650997 0.19541831
		 -0.0035606008 0.19541831 -0.0044563692 0.19541831 -0.0053520184 0.19541831 -0.0062476676
		 0.19541831 -0.0071433764 0.19541831 -0.0080388766 0.19541831 -0.0089346748 0.19541831
		 -0.0098304208 0.19541831 -0.010726055 0.19541831 -0.011621496 0.19541831 -0.012517055
		 0.19541831 0.014352422 0.19486372 0.013456859 0.19486372 0.012561116 0.19486372 0.011665519
		 0.19486372 0.010769788 0.19486372 0.0098742284 0.19486372 0.0089785261 0.19486372
		 0.0080828769 0.19486372 0.0071872426 0.19486372 0.0062915636 0.19486372 0.0053959144
		 0.19486372 0.0045002354 0.19486372 0.0036045415 0.19486372 0.0027088923 0.19486372
		 0.0018132357 0.19486372 0.0009175567 0.19486372 2.1967106e-005 0.19486372 -0.0008737715
		 0.19486372 -0.0017694207 0.19486372 -0.0026650997 0.19486372 -0.0035606008 0.19486372
		 -0.0044563692 0.19486372 -0.0053520184 0.19486372 -0.0062476676 0.19486372 -0.0071433764
		 0.19486372 -0.0080388766 0.19486372 -0.0089346748 0.19486372 -0.0098304208 0.19486372
		 -0.010726055 0.19486372 -0.011621496 0.19486372 -0.012517055 0.19486372 0.014352422
		 0.19430898 0.013456859 0.19430898 0.012561116 0.19430898 0.011665519 0.19430898 0.010769788
		 0.19430898 0.0098742284 0.19430898 0.0089785261 0.19430898 0.0080828769 0.19430898
		 0.0071872426 0.19430898 0.0062915636 0.19430898 0.0053959144 0.19430898 0.0045002354
		 0.19430898 0.0036045415 0.19430898 0.0027088923 0.19430898 0.0018132357 0.19430898
		 0.0009175567 0.19430898 2.1967106e-005 0.19430898 -0.0008737715 0.19430898 -0.0017694207
		 0.19430898 -0.0026650997 0.19430898 -0.0035606008 0.19430898 -0.0044563692 0.19430898
		 -0.0053520184 0.19430898 -0.0062476676 0.19430898 -0.0071433764 0.19430898 -0.0080388766
		 0.19430898 -0.0089346748 0.19430898 -0.0098304208 0.19430898 -0.010726055 0.19430898
		 -0.011621496 0.19430898 -0.012517055 0.19430898 0.014352422 0.19375436 0.013456859
		 0.19375436;
	setAttr ".uvtk[250:499]" 0.012561116 0.19375436 0.011665519 0.19375436 0.010769788
		 0.19375436 0.0098742284 0.19375436 0.0089785261 0.19375436 0.0080828769 0.19375436
		 0.0071872426 0.19375436 0.0062915636 0.19375436 0.0053959144 0.19375436 0.0045002354
		 0.19375436 0.0036045415 0.19375436 0.0027088923 0.19375436 0.0018132357 0.19375436
		 0.0009175567 0.19375436 2.1967106e-005 0.19375436 -0.0008737715 0.19375436 -0.0017694207
		 0.19375436 -0.0026650997 0.19375436 -0.0035606008 0.19375436 -0.0044563692 0.19375436
		 -0.0053520184 0.19375436 -0.0062476676 0.19375436 -0.0071433764 0.19375436 -0.0080388766
		 0.19375436 -0.0089346748 0.19375436 -0.0098304208 0.19375436 -0.010726055 0.19375436
		 -0.011621496 0.19375436 -0.012517055 0.19375436 0.014352422 0.19319968 0.013456859
		 0.19319968 0.012561116 0.19319968 0.011665519 0.19319968 0.010769788 0.19319968 0.0098742284
		 0.19319968 0.0089785261 0.19319968 0.0080828769 0.19319968 0.0071872426 0.19319968
		 0.0062915636 0.19319968 0.0053959144 0.19319968 0.0045002354 0.19319968 0.0036045415
		 0.19319968 0.0027088923 0.19319968 0.0018132357 0.19319968 0.0009175567 0.19319968
		 2.1967106e-005 0.19319968 -0.0008737715 0.19319968 -0.0017694207 0.19319968 -0.0026650997
		 0.19319968 -0.0035606008 0.19319968 -0.0044563692 0.19319968 -0.0053520184 0.19319968
		 -0.0062476676 0.19319968 -0.0071433764 0.19319968 -0.0080388766 0.19319968 -0.0089346748
		 0.19319968 -0.0098304208 0.19319968 -0.010726055 0.19319968 -0.011621496 0.19319968
		 -0.012517055 0.19319968 0.014352422 0.19264515 0.013456859 0.19264515 0.012561116
		 0.19264515 0.011665519 0.19264515 0.010769788 0.19264515 0.0098742284 0.19264515
		 0.0089785261 0.19264515 0.0080828769 0.19264515 0.0071872426 0.19264515 0.0062915636
		 0.19264515 0.0053959144 0.19264515 0.0045002354 0.19264515 0.0036045415 0.19264515
		 0.0027088923 0.19264515 0.0018132357 0.19264515 0.0009175567 0.19264515 2.1967106e-005
		 0.19264515 -0.0008737715 0.19264515 -0.0017694207 0.19264515 -0.0026650997 0.19264515
		 -0.0035606008 0.19264515 -0.0044563692 0.19264515 -0.0053520184 0.19264515 -0.0062476676
		 0.19264515 -0.0071433764 0.19264515 -0.0080388766 0.19264515 -0.0089346748 0.19264515
		 -0.0098304208 0.19264515 -0.010726055 0.19264515 -0.011621496 0.19264515 -0.012517055
		 0.19264515 0.014352422 0.19209041 0.013456859 0.19209041 0.012561116 0.19209041 0.011665519
		 0.19209041 0.010769788 0.19209041 0.0098742284 0.19209041 0.0089785261 0.19209041
		 0.0080828769 0.19209041 0.0071872426 0.19209041 0.0062915636 0.19209041 0.0053959144
		 0.19209041 0.0045002354 0.19209041 0.0036045415 0.19209041 0.0027088923 0.19209041
		 0.0018132357 0.19209041 0.0009175567 0.19209041 2.1967106e-005 0.19209041 -0.0008737715
		 0.19209041 -0.0017694207 0.19209041 -0.0026650997 0.19209041 -0.0035606008 0.19209041
		 -0.0044563692 0.19209041 -0.0053520184 0.19209041 -0.0062476676 0.19209041 -0.0071433764
		 0.19209041 -0.0080388766 0.19209041 -0.0089346748 0.19209041 -0.0098304208 0.19209041
		 -0.010726055 0.19209041 -0.011621496 0.19209041 -0.012517055 0.19209041 0.014352422
		 0.19153561 0.013456859 0.19153561 0.012561116 0.19153561 0.011665519 0.19153561 0.010769788
		 0.19153561 0.0098742284 0.19153561 0.0089785261 0.19153561 0.0080828769 0.19153561
		 0.0071872426 0.19153561 0.0062915636 0.19153561 0.0053959144 0.19153561 0.0045002354
		 0.19153561 0.0036045415 0.19153561 0.0027088923 0.19153561 0.0018132357 0.19153561
		 0.0009175567 0.19153561 2.1967106e-005 0.19153561 -0.0008737715 0.19153561 -0.0017694207
		 0.19153561 -0.0026650997 0.19153561 -0.0035606008 0.19153561 -0.0044563692 0.19153561
		 -0.0053520184 0.19153561 -0.0062476676 0.19153561 -0.0071433764 0.19153561 -0.0080388766
		 0.19153561 -0.0089346748 0.19153561 -0.0098304208 0.19153561 -0.010726055 0.19153561
		 -0.011621496 0.19153561 -0.012517055 0.19153561 0.014352422 0.19098099 0.013456859
		 0.19098099 0.012561116 0.19098099 0.011665519 0.19098099 0.010769788 0.19098099 0.0098742284
		 0.19098099 0.0089785261 0.19098099 0.0080828769 0.19098099 0.0071872426 0.19098099
		 0.0062915636 0.19098099 0.0053959144 0.19098099 0.0045002354 0.19098099 0.0036045415
		 0.19098099 0.0027088923 0.19098099 0.0018132357 0.19098099 0.0009175567 0.19098099
		 2.1967106e-005 0.19098099 -0.0008737715 0.19098099 -0.0017694207 0.19098099 -0.0026650997
		 0.19098099 -0.0035606008 0.19098099 -0.0044563692 0.19098099 -0.0053520184 0.19098099
		 -0.0062476676 0.19098099 -0.0071433764 0.19098099 -0.0080388766 0.19098099 -0.0089346748
		 0.19098099 -0.0098304208 0.19098099 -0.010726055 0.19098099 -0.011621496 0.19098099
		 -0.012517055 0.19098099 0.014352422 0.19042639 0.013456859 0.19042639 0.012561116
		 0.19042639 0.011665519 0.19042639 0.010769788 0.19042639 0.0098742284 0.19042639
		 0.0089785261 0.19042639 0.0080828769 0.19042639 0.0071872426 0.19042639 0.0062915636
		 0.19042639 0.0053959144 0.19042639 0.0045002354 0.19042639 0.0036045415 0.19042639
		 0.0027088923 0.19042639 0.0018132357 0.19042639 0.0009175567 0.19042639 2.1967106e-005
		 0.19042639 -0.0008737715 0.19042639 -0.0017694207 0.19042639 -0.0026650997 0.19042639
		 -0.0035606008 0.19042639 -0.0044563692 0.19042639 -0.0053520184 0.19042639 -0.0062476676
		 0.19042639 -0.0071433764 0.19042639 -0.0080388766 0.19042639 -0.0089346748 0.19042639
		 -0.0098304208 0.19042639 -0.010726055 0.19042639 -0.011621496 0.19042639 -0.012517055
		 0.19042639 0.014352422 0.18987174 0.013456859 0.18987174 0.012561116 0.18987174 0.011665519
		 0.18987174 0.010769788 0.18987174 0.0098742284 0.18987174 0.0089785261 0.18987174
		 0.0080828769 0.18987174 0.0071872426 0.18987174 0.0062915636 0.18987174 0.0053959144
		 0.18987174 0.0045002354 0.18987174 0.0036045415 0.18987174 0.0027088923 0.18987174
		 0.0018132357 0.18987174 0.0009175567 0.18987174 2.1967106e-005 0.18987174 -0.0008737715
		 0.18987174 -0.0017694207 0.18987174 -0.0026650997 0.18987174 -0.0035606008 0.18987174
		 -0.0044563692 0.18987174 -0.0053520184 0.18987174 -0.0062476676 0.18987174 -0.0071433764
		 0.18987174 -0.0080388766 0.18987174 -0.0089346748 0.18987174 -0.0098304208 0.18987174
		 -0.010726055 0.18987174 -0.011621496 0.18987174 -0.012517055 0.18987174 0.014352422
		 0.18931712 0.013456859 0.18931712 0.012561116 0.18931712 0.011665519 0.18931712;
	setAttr ".uvtk[500:749]" 0.010769788 0.18931712 0.0098742284 0.18931712 0.0089785261
		 0.18931712 0.0080828769 0.18931712 0.0071872426 0.18931712 0.0062915636 0.18931712
		 0.0053959144 0.18931712 0.0045002354 0.18931712 0.0036045415 0.18931712 0.0027088923
		 0.18931712 0.0018132357 0.18931712 0.0009175567 0.18931712 2.1967106e-005 0.18931712
		 -0.0008737715 0.18931712 -0.0017694207 0.18931712 -0.0026650997 0.18931712 -0.0035606008
		 0.18931712 -0.0044563692 0.18931712 -0.0053520184 0.18931712 -0.0062476676 0.18931712
		 -0.0071433764 0.18931712 -0.0080388766 0.18931712 -0.0089346748 0.18931712 -0.0098304208
		 0.18931712 -0.010726055 0.18931712 -0.011621496 0.18931712 -0.012517055 0.18931712
		 0.014352422 0.18876226 0.013456859 0.18876226 0.012561116 0.18876226 0.011665519
		 0.18876226 0.010769788 0.18876226 0.0098742284 0.18876226 0.0089785261 0.18876226
		 0.0080828769 0.18876226 0.0071872426 0.18876226 0.0062915636 0.18876226 0.0053959144
		 0.18876226 0.0045002354 0.18876226 0.0036045415 0.18876226 0.0027088923 0.18876226
		 0.0018132357 0.18876226 0.0009175567 0.18876226 2.1967106e-005 0.18876226 -0.0008737715
		 0.18876226 -0.0017694207 0.18876226 -0.0026650997 0.18876226 -0.0035606008 0.18876226
		 -0.0044563692 0.18876226 -0.0053520184 0.18876226 -0.0062476676 0.18876226 -0.0071433764
		 0.18876226 -0.0080388766 0.18876226 -0.0089346748 0.18876226 -0.0098304208 0.18876226
		 -0.010726055 0.18876226 -0.011621496 0.18876226 -0.012517055 0.18876226 0.014352422
		 0.18820776 0.013456859 0.18820776 0.012561116 0.18820776 0.011665519 0.18820776 0.010769788
		 0.18820776 0.0098742284 0.18820776 0.0089785261 0.18820776 0.0080828769 0.18820776
		 0.0071872426 0.18820776 0.0062915636 0.18820776 0.0053959144 0.18820776 0.0045002354
		 0.18820776 0.0036045415 0.18820776 0.0027088923 0.18820776 0.0018132357 0.18820776
		 0.0009175567 0.18820776 2.1967106e-005 0.18820776 -0.0008737715 0.18820776 -0.0017694207
		 0.18820776 -0.0026650997 0.18820776 -0.0035606008 0.18820776 -0.0044563692 0.18820776
		 -0.0053520184 0.18820776 -0.0062476676 0.18820776 -0.0071433764 0.18820776 -0.0080388766
		 0.18820776 -0.0089346748 0.18820776 -0.0098304208 0.18820776 -0.010726055 0.18820776
		 -0.011621496 0.18820776 -0.012517055 0.18820776 0.014352422 0.18765296 0.013456859
		 0.18765296 0.012561116 0.18765296 0.011665519 0.18765296 0.010769788 0.18765296 0.0098742284
		 0.18765296 0.0089785261 0.18765296 0.0080828769 0.18765296 0.0071872426 0.18765296
		 0.0062915636 0.18765296 0.0053959144 0.18765296 0.0045002354 0.18765296 0.0036045415
		 0.18765296 0.0027088923 0.18765296 0.0018132357 0.18765296 0.0009175567 0.18765296
		 2.1967106e-005 0.18765296 -0.0008737715 0.18765296 -0.0017694207 0.18765296 -0.0026650997
		 0.18765296 -0.0035606008 0.18765296 -0.0044563692 0.18765296 -0.0053520184 0.18765296
		 -0.0062476676 0.18765296 -0.0071433764 0.18765296 -0.0080388766 0.18765296 -0.0089346748
		 0.18765296 -0.0098304208 0.18765296 -0.010726055 0.18765296 -0.011621496 0.18765296
		 -0.012517055 0.18765296 0.014352422 0.18709834 0.013456859 0.18709834 0.012561116
		 0.18709834 0.011665519 0.18709834 0.010769788 0.18709834 0.0098742284 0.18709834
		 0.0089785261 0.18709834 0.0080828769 0.18709834 0.0071872426 0.18709834 0.0062915636
		 0.18709834 0.0053959144 0.18709834 0.0045002354 0.18709834 0.0036045415 0.18709834
		 0.0027088923 0.18709834 0.0018132357 0.18709834 0.0009175567 0.18709834 2.1967106e-005
		 0.18709834 -0.0008737715 0.18709834 -0.0017694207 0.18709834 -0.0026650997 0.18709834
		 -0.0035606008 0.18709834 -0.0044563692 0.18709834 -0.0053520184 0.18709834 -0.0062476676
		 0.18709834 -0.0071433764 0.18709834 -0.0080388766 0.18709834 -0.0089346748 0.18709834
		 -0.0098304208 0.18709834 -0.010726055 0.18709834 -0.011621496 0.18709834 -0.012517055
		 0.18709834 0.014352422 0.18654372 0.013456859 0.18654372 0.012561116 0.18654372 0.011665519
		 0.18654372 0.010769788 0.18654372 0.0098742284 0.18654372 0.0089785261 0.18654372
		 0.0080828769 0.18654372 0.0071872426 0.18654372 0.0062915636 0.18654372 0.0053959144
		 0.18654372 0.0045002354 0.18654372 0.0036045415 0.18654372 0.0027088923 0.18654372
		 0.0018132357 0.18654372 0.0009175567 0.18654372 2.1967106e-005 0.18654372 -0.0008737715
		 0.18654372 -0.0017694207 0.18654372 -0.0026650997 0.18654372 -0.0035606008 0.18654372
		 -0.0044563692 0.18654372 -0.0053520184 0.18654372 -0.0062476676 0.18654372 -0.0071433764
		 0.18654372 -0.0080388766 0.18654372 -0.0089346748 0.18654372 -0.0098304208 0.18654372
		 -0.010726055 0.18654372 -0.011621496 0.18654372 -0.012517055 0.18654372 0.014352422
		 0.18598922 0.013456859 0.18598922 0.012561116 0.18598922 0.011665519 0.18598922 0.010769788
		 0.18598922 0.0098742284 0.18598922 0.0089785261 0.18598922 0.0080828769 0.18598922
		 0.0071872426 0.18598922 0.0062915636 0.18598922 0.0053959144 0.18598922 0.0045002354
		 0.18598922 0.0036045415 0.18598922 0.0027088923 0.18598922 0.0018132357 0.18598922
		 0.0009175567 0.18598922 2.1967106e-005 0.18598922 -0.0008737715 0.18598922 -0.0017694207
		 0.18598922 -0.0026650997 0.18598922 -0.0035606008 0.18598922 -0.0044563692 0.18598922
		 -0.0053520184 0.18598922 -0.0062476676 0.18598922 -0.0071433764 0.18598922 -0.0080388766
		 0.18598922 -0.0089346748 0.18598922 -0.0098304208 0.18598922 -0.010726055 0.18598922
		 -0.011621496 0.18598922 -0.012517055 0.18598922 0.014352422 0.18543448 0.013456859
		 0.18543448 0.012561116 0.18543448 0.011665519 0.18543448 0.010769788 0.18543448 0.0098742284
		 0.18543448 0.0089785261 0.18543448 0.0080828769 0.18543448 0.0071872426 0.18543448
		 0.0062915636 0.18543448 0.0053959144 0.18543448 0.0045002354 0.18543448 0.0036045415
		 0.18543448 0.0027088923 0.18543448 0.0018132357 0.18543448 0.0009175567 0.18543448
		 2.1967106e-005 0.18543448 -0.0008737715 0.18543448 -0.0017694207 0.18543448 -0.0026650997
		 0.18543448 -0.0035606008 0.18543448 -0.0044563692 0.18543448 -0.0053520184 0.18543448
		 -0.0062476676 0.18543448 -0.0071433764 0.18543448 -0.0080388766 0.18543448 -0.0089346748
		 0.18543448 -0.0098304208 0.18543448 -0.010726055 0.18543448 -0.011621496 0.18543448
		 -0.012517055 0.18543448 0.014352422 0.18487985 0.013456859 0.18487985 0.012561116
		 0.18487985 0.011665519 0.18487985 0.010769788 0.18487985 0.0098742284 0.18487985;
	setAttr ".uvtk[750:960]" 0.0089785261 0.18487985 0.0080828769 0.18487985 0.0071872426
		 0.18487985 0.0062915636 0.18487985 0.0053959144 0.18487985 0.0045002354 0.18487985
		 0.0036045415 0.18487985 0.0027088923 0.18487985 0.0018132357 0.18487985 0.0009175567
		 0.18487985 2.1967106e-005 0.18487985 -0.0008737715 0.18487985 -0.0017694207 0.18487985
		 -0.0026650997 0.18487985 -0.0035606008 0.18487985 -0.0044563692 0.18487985 -0.0053520184
		 0.18487985 -0.0062476676 0.18487985 -0.0071433764 0.18487985 -0.0080388766 0.18487985
		 -0.0089346748 0.18487985 -0.0098304208 0.18487985 -0.010726055 0.18487985 -0.011621496
		 0.18487985 -0.012517055 0.18487985 0.014352422 0.18432511 0.013456859 0.18432511
		 0.012561116 0.18432511 0.011665519 0.18432511 0.010769788 0.18432511 0.0098742284
		 0.18432511 0.0089785261 0.18432511 0.0080828769 0.18432511 0.0071872426 0.18432511
		 0.0062915636 0.18432511 0.0053959144 0.18432511 0.0045002354 0.18432511 0.0036045415
		 0.18432511 0.0027088923 0.18432511 0.0018132357 0.18432511 0.0009175567 0.18432511
		 2.1967106e-005 0.18432511 -0.0008737715 0.18432511 -0.0017694207 0.18432511 -0.0026650997
		 0.18432511 -0.0035606008 0.18432511 -0.0044563692 0.18432511 -0.0053520184 0.18432511
		 -0.0062476676 0.18432511 -0.0071433764 0.18432511 -0.0080388766 0.18432511 -0.0089346748
		 0.18432511 -0.0098304208 0.18432511 -0.010726055 0.18432511 -0.011621496 0.18432511
		 -0.012517055 0.18432511 0.014352422 0.18377061 0.013456859 0.18377061 0.012561116
		 0.18377061 0.011665519 0.18377061 0.010769788 0.18377061 0.0098742284 0.18377061
		 0.0089785261 0.18377061 0.0080828769 0.18377061 0.0071872426 0.18377061 0.0062915636
		 0.18377061 0.0053959144 0.18377061 0.0045002354 0.18377061 0.0036045415 0.18377061
		 0.0027088923 0.18377061 0.0018132357 0.18377061 0.0009175567 0.18377061 2.1967106e-005
		 0.18377061 -0.0008737715 0.18377061 -0.0017694207 0.18377061 -0.0026650997 0.18377061
		 -0.0035606008 0.18377061 -0.0044563692 0.18377061 -0.0053520184 0.18377061 -0.0062476676
		 0.18377061 -0.0071433764 0.18377061 -0.0080388766 0.18377061 -0.0089346748 0.18377061
		 -0.0098304208 0.18377061 -0.010726055 0.18377061 -0.011621496 0.18377061 -0.012517055
		 0.18377061 0.014352422 0.18321599 0.013456859 0.18321599 0.012561116 0.18321599 0.011665519
		 0.18321599 0.010769788 0.18321599 0.0098742284 0.18321599 0.0089785261 0.18321599
		 0.0080828769 0.18321599 0.0071872426 0.18321599 0.0062915636 0.18321599 0.0053959144
		 0.18321599 0.0045002354 0.18321599 0.0036045415 0.18321599 0.0027088923 0.18321599
		 0.0018132357 0.18321599 0.0009175567 0.18321599 2.1967106e-005 0.18321599 -0.0008737715
		 0.18321599 -0.0017694207 0.18321599 -0.0026650997 0.18321599 -0.0035606008 0.18321599
		 -0.0044563692 0.18321599 -0.0053520184 0.18321599 -0.0062476676 0.18321599 -0.0071433764
		 0.18321599 -0.0080388766 0.18321599 -0.0089346748 0.18321599 -0.0098304208 0.18321599
		 -0.010726055 0.18321599 -0.011621496 0.18321599 -0.012517055 0.18321599 0.014352422
		 0.18266119 0.013456859 0.18266119 0.012561116 0.18266119 0.011665519 0.18266119 0.010769788
		 0.18266119 0.0098742284 0.18266119 0.0089785261 0.18266119 0.0080828769 0.18266119
		 0.0071872426 0.18266119 0.0062915636 0.18266119 0.0053959144 0.18266119 0.0045002354
		 0.18266119 0.0036045415 0.18266119 0.0027088923 0.18266119 0.0018132357 0.18266119
		 0.0009175567 0.18266119 2.1967106e-005 0.18266119 -0.0008737715 0.18266119 -0.0017694207
		 0.18266119 -0.0026650997 0.18266119 -0.0035606008 0.18266119 -0.0044563692 0.18266119
		 -0.0053520184 0.18266119 -0.0062476676 0.18266119 -0.0071433764 0.18266119 -0.0080388766
		 0.18266119 -0.0089346748 0.18266119 -0.0098304208 0.18266119 -0.010726055 0.18266119
		 -0.011621496 0.18266119 -0.012517055 0.18266119 0.014352422 0.18210645 0.013456859
		 0.18210645 0.012561116 0.18210645 0.011665519 0.18210645 0.010769788 0.18210645 0.0098742284
		 0.18210645 0.0089785261 0.18210645 0.0080828769 0.18210645 0.0071872426 0.18210645
		 0.0062915636 0.18210645 0.0053959144 0.18210645 0.0045002354 0.18210645 0.0036045415
		 0.18210645 0.0027088923 0.18210645 0.0018132357 0.18210645 0.0009175567 0.18210645
		 2.1967106e-005 0.18210645 -0.0008737715 0.18210645 -0.0017694207 0.18210645 -0.0026650997
		 0.18210645 -0.0035606008 0.18210645 -0.0044563692 0.18210645 -0.0053520184 0.18210645
		 -0.0062476676 0.18210645 -0.0071433764 0.18210645 -0.0080388766 0.18210645 -0.0089346748
		 0.18210645 -0.0098304208 0.18210645 -0.010726055 0.18210645 -0.011621496 0.18210645
		 -0.012517055 0.18210645 0.014352422 0.18155183 0.013456859 0.18155183 0.012561116
		 0.18155183 0.011665519 0.18155183 0.010769788 0.18155183 0.0098742284 0.18155183
		 0.0089785261 0.18155183 0.0080828769 0.18155183 0.0071872426 0.18155183 0.0062915636
		 0.18155183 0.0053959144 0.18155183 0.0045002354 0.18155183 0.0036045415 0.18155183
		 0.0027088923 0.18155183 0.0018132357 0.18155183 0.0009175567 0.18155183 2.1967106e-005
		 0.18155183 -0.0008737715 0.18155183 -0.0017694207 0.18155183 -0.0026650997 0.18155183
		 -0.0035606008 0.18155183 -0.0044563692 0.18155183 -0.0053520184 0.18155183 -0.0062476676
		 0.18155183 -0.0071433764 0.18155183 -0.0080388766 0.18155183 -0.0089346748 0.18155183
		 -0.0098304208 0.18155183 -0.010726055 0.18155183 -0.011621496 0.18155183 -0.012517055
		 0.18155183;
createNode polyMapCut -n "polyMapCut1";
	rename -uid "4C32C290-46F0-F3B6-50BF-8EA7E6911CA2";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[0:2]" "e[4:5]";
createNode polyTweakUV -n "polyTweakUV3";
	rename -uid "6DFDD58D-400C-DEAF-01AB-B7986ED47C84";
	setAttr ".uopa" yes;
	setAttr -s 20 ".uvtk";
	setAttr ".uvtk[1]" -type "float2" 1.7881393e-007 3.7252903e-007 ;
	setAttr ".uvtk[2]" -type "float2" -1.1324883e-006 -3.8743019e-007 ;
	setAttr ".uvtk[3]" -type "float2" -1.7881393e-007 1.4901161e-007 ;
	setAttr ".uvtk[4]" -type "float2" -1.7881393e-007 3.8743019e-007 ;
	setAttr ".uvtk[6]" -type "float2" -2.3841858e-007 5.9604645e-008 ;
	setAttr ".uvtk[7]" -type "float2" -1.7881393e-007 1.1920929e-007 ;
	setAttr ".uvtk[8]" -type "float2" -1.1920929e-007 8.9406967e-008 ;
	setAttr ".uvtk[9]" -type "float2" -1.1920929e-007 2.9802322e-007 ;
	setAttr ".uvtk[10]" -type "float2" -1.7881393e-007 4.7683716e-007 ;
	setAttr ".uvtk[11]" -type "float2" -3.5762787e-007 4.7087669e-006 ;
	setAttr ".uvtk[12]" -type "float2" -3.5762787e-007 4.4107437e-006 ;
	setAttr ".uvtk[13]" -type "float2" 0 4.6491623e-006 ;
	setAttr ".uvtk[14]" -type "float2" 0 4.4703484e-006 ;
	setAttr ".uvtk[15]" -type "float2" 1.7881393e-007 4.0531158e-006 ;
	setAttr ".uvtk[16]" -type "float2" 4.1723251e-007 4.4107437e-006 ;
	setAttr ".uvtk[17]" -type "float2" 4.1723251e-007 3.9935112e-006 ;
	setAttr ".uvtk[18]" -type "float2" 0 4.9471855e-006 ;
	setAttr ".uvtk[19]" -type "float2" -1.7881393e-007 3.7550926e-006 ;
	setAttr ".uvtk[20]" -type "float2" 3.5762787e-007 4.5895576e-006 ;
	setAttr ".uvtk[21]" -type "float2" -6.5565109e-007 4.2319298e-006 ;
createNode polyMapCut -n "polyMapCut2";
	rename -uid "0AB1656B-4426-0B76-7F73-6EAF6DB9C64F";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 4 "e[0:2]" "e[4:5]" "e[12:14]" "e[17]";
createNode polyTweakUV -n "polyTweakUV4";
	rename -uid "75111715-4AB5-F1A6-8432-3B87504E0041";
	setAttr ".uopa" yes;
	setAttr -s 4 ".uvtk";
	setAttr ".uvtk[0]" -type "float2" 0.004126762 0.10454169 ;
	setAttr ".uvtk[1]" -type "float2" 0.04739096 0.076498941 ;
	setAttr ".uvtk[2]" -type "float2" 0.045468252 0.023217827 ;
	setAttr ".uvtk[5]" -type "float2" -0.043313116 0.026034368 ;
createNode polyMapSewMove -n "polyMapSewMove3";
	rename -uid "150CE761-49A8-B1AA-3F75-F8B70EF02BA7";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[13:14]" "e[17]";
createNode polyTweakUV -n "polyTweakUV5";
	rename -uid "17F31620-4810-9C24-3D08-EAA6B6070F15";
	setAttr ".uopa" yes;
	setAttr -s 22 ".uvtk[0:21]" -type "float2" 0.39652723 0.66508418 0.40344912
		 0.64737183 0.39080817 0.63430923 0.37158114 0.63693523 0.36517107 0.64948231 0.37194717
		 0.66782594 0.38613486 0.59980923 0.38128346 0.6121847 0.37643224 0.62455857 0.36031634
		 0.66183436 0.35546196 0.67418444 -0.48006877 0.26020205 -0.48491871 0.27257621 -0.48976877
		 0.28494912 -0.49461669 0.29731795 -0.49945578 0.30968389 -0.50431007 0.32203692 -0.50916368
		 0.33439007 -0.50318426 0.28715324 -0.51632911 0.28963736 -0.52077073 0.30212185 -0.51220024
		 0.31219053;
createNode cacheFile -n "nClothShape1Cache1";
	rename -uid "DBDD8190-430D-C301-0A19-D0B9FDC641E4";
	setAttr ".cn" -type "string" "nClothShape1";
	setAttr ".cp" -type "string" "C:/Users/CELESTEE/Desktop/Celeste FINISH/";
	setAttr ".ch[0]" -type "string" "nClothShape1";
	setAttr ".os" 1;
	setAttr ".oe" 300;
	setAttr ".ss" 1;
	setAttr ".se" 300;
	setAttr ".sf" -100;
	setAttr ".tr" 1;
createNode cacheBlend -n "cacheBlend1";
	rename -uid "9D303EE0-495D-0A0A-B867-8CA5B5B5F5F5";
	addAttr -ci true -h true -sn "aal" -ln "attributeAliasList" -dt "attributeAlias";
	setAttr -s 2 ".ic[0].va";
	setAttr -s 2 ".cd[0:1]" -100 199 no 0 101 400 yes 1;
	setAttr -s 2 ".cd";
	setAttr -k on ".cd[0].w";
	setAttr -k on ".cd[1].w";
	setAttr ".aal" -type "attributeAlias" {"nClothShape1Cache1","cacheData[0].weight"
		,"nClothShape1Cache2","cacheData[1].weight"} ;
createNode cacheFile -n "nClothShape1Cache2";
	rename -uid "5BAE4F27-4751-949E-CCCE-82B96BE3D5BC";
	setAttr ".cn" -type "string" "nClothShape1";
	setAttr ".cp" -type "string" "C:/Users/CELESTEE/Desktop/Celeste FINISH/";
	setAttr ".ch[0]" -type "string" "nClothShape1";
	setAttr ".os" 1;
	setAttr ".oe" 300;
	setAttr ".ss" 1;
	setAttr ".se" 300;
	setAttr ".sf" 101;
	setAttr ".tr" 2;
createNode animCurveTU -n "cacheBlend1_nClothShape1Cache1";
	rename -uid "B9D8F93D-48DD-F86A-3534-048756A6AA97";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 2 ".ktv[0:1]"  100 1 200 0;
createNode animCurveTU -n "cacheBlend1_nClothShape1Cache2";
	rename -uid "DE77B04C-41A2-62F4-5EF5-4490AACF2459";
	setAttr ".tan" 18;
	setAttr ".wgt" no;
	setAttr -s 2 ".ktv[0:1]"  100 0 200 1;
select -ne :time1;
	setAttr ".ihi" 0;
	setAttr ".o" 200;
	setAttr ".unw" 200;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 3 ".dsm";
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "polyTweakUV5.out" "pCylinderShape1.i";
connectAttr "polyTweakUV5.uvtk[0]" "pCylinderShape1.uvst[0].uvtw";
connectAttr "polyPlane1.out" "pPlaneShape1.i";
connectAttr "polyTweakUV2.out" "outputCloth1.i";
connectAttr "polyTweakUV2.uvtk[0]" "outputCloth1.uvst[0].uvtw";
connectAttr ":time1.o" "nucleus1.cti";
connectAttr "nClothShape1.cust" "nucleus1.niao[0]";
connectAttr "nClothShape1.stst" "nucleus1.nias[0]";
connectAttr "dynamicConstraintShape1.evs" "nucleus1.is[0]";
connectAttr "dynamicConstraintShape1.evc" "nucleus1.ic[0]";
connectAttr "nRigidShape1.cust" "nucleus1.nipo[0]";
connectAttr "nRigidShape1.stst" "nucleus1.nips[0]";
connectAttr "nucleus1.stf" "nClothShape1.stf";
connectAttr ":time1.o" "nClothShape1.cti";
connectAttr "pPlaneShape1.w" "nClothShape1.imsh";
connectAttr "nucleus1.noao[0]" "nClothShape1.nxst";
connectAttr "cacheBlend1.ocd[0]" "nClothShape1.poss";
connectAttr "cacheBlend1.ir" "nClothShape1.pfc";
connectAttr "nComponent1.ocp" "dynamicConstraintShape1.cid[0]";
connectAttr ":time1.o" "dynamicConstraintShape1.cti";
connectAttr "nucleus1.stf" "nRigidShape1.stf";
connectAttr ":time1.o" "nRigidShape1.cti";
connectAttr "pCylinderShape1.w" "nRigidShape1.imsh";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "nClothShape1.nuid" "nComponent1.obid";
connectAttr "polyCylinder1.out" "polyMapSewMove1.ip";
connectAttr "polyMapSewMove1.out" "polyMapSewMove2.ip";
connectAttr "polyMapSewMove2.out" "polyTweakUV1.ip";
connectAttr "nClothShape1.omsh" "polyTweakUV2.ip";
connectAttr "polyTweakUV1.out" "polyMapCut1.ip";
connectAttr "polyMapCut1.out" "polyTweakUV3.ip";
connectAttr "polyTweakUV3.out" "polyMapCut2.ip";
connectAttr "polyMapCut2.out" "polyTweakUV4.ip";
connectAttr "polyTweakUV4.out" "polyMapSewMove3.ip";
connectAttr "polyMapSewMove3.out" "polyTweakUV5.ip";
connectAttr ":time1.o" "nClothShape1Cache1.tim";
connectAttr "cacheBlend1_nClothShape1Cache1.o" "cacheBlend1.cd[0].w";
connectAttr "nClothShape1Cache1.st" "cacheBlend1.cd[0].st";
connectAttr "nClothShape1Cache1.e" "cacheBlend1.cd[0].e";
connectAttr "nClothShape1Cache1.ir" "cacheBlend1.cd[0].ra";
connectAttr "cacheBlend1_nClothShape1Cache2.o" "cacheBlend1.cd[1].w";
connectAttr "nClothShape1Cache2.st" "cacheBlend1.cd[1].st";
connectAttr "nClothShape1Cache2.e" "cacheBlend1.cd[1].e";
connectAttr "nClothShape1Cache2.ir" "cacheBlend1.cd[1].ra";
connectAttr "nClothShape1Cache1.ocd[0]" "cacheBlend1.ic[0].va[0]";
connectAttr "nClothShape1Cache2.ocd[0]" "cacheBlend1.ic[0].va[1]";
connectAttr ":time1.o" "nClothShape1Cache2.tim";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pCylinderShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pPlaneShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "outputCloth1.iog" ":initialShadingGroup.dsm" -na;
// End of Flag.ma
