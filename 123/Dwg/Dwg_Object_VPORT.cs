//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_VPORT : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_VPORT(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_VPORT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_VPORT() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_Object_VPORT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public byte flag {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_flag_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_flag_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_VPORT_name_get(swigCPtr);
      return ret;
    } 
  }

  public ushort used {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_used_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_used_get(swigCPtr);
      return ret;
    } 
  }

  public byte xrefref {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_xrefref_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_xrefref_get(swigCPtr);
      return ret;
    } 
  }

  public ushort xrefindex_plus1 {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_xrefindex_plus1_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_xrefindex_plus1_get(swigCPtr);
      return ret;
    } 
  }

  public byte xrefdep {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_xrefdep_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_xrefdep_get(swigCPtr);
      return ret;
    } 
  }

  public double VIEWSIZE {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWSIZE_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWSIZE_get(swigCPtr);
      return ret;
    } 
  }

  public double viewwidth {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_viewwidth_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_viewwidth_get(swigCPtr);
      return ret;
    } 
  }

  public double aspect_ratio {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_aspect_ratio_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_aspect_ratio_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD VIEWCTR {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWCTR_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWCTR_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD view_target {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_view_target_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_view_target_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD VIEWDIR {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWDIR_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWDIR_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double view_twist {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_view_twist_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_view_twist_get(swigCPtr);
      return ret;
    } 
  }

  public double lens_length {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_lens_length_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_lens_length_get(swigCPtr);
      return ret;
    } 
  }

  public double front_clip {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_front_clip_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_front_clip_get(swigCPtr);
      return ret;
    } 
  }

  public double back_clip {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_back_clip_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_back_clip_get(swigCPtr);
      return ret;
    } 
  }

  public byte VIEWMODE {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWMODE_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_VIEWMODE_get(swigCPtr);
      return ret;
    } 
  }

  public byte render_mode {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_render_mode_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_render_mode_get(swigCPtr);
      return ret;
    } 
  }

  public byte use_default_lights {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_use_default_lights_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_use_default_lights_get(swigCPtr);
      return ret;
    } 
  }

  public byte default_lightning_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_default_lightning_type_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_default_lightning_type_get(swigCPtr);
      return ret;
    } 
  }

  public double brightness {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_brightness_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_brightness_get(swigCPtr);
      return ret;
    } 
  }

  public double contrast {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_contrast_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_contrast_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color ambient_color {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_ambient_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_ambient_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD lower_left {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_lower_left_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_lower_left_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD upper_right {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_upper_right_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_upper_right_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public byte UCSFOLLOW {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_UCSFOLLOW_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_UCSFOLLOW_get(swigCPtr);
      return ret;
    } 
  }

  public ushort circle_zoom {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_circle_zoom_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_circle_zoom_get(swigCPtr);
      return ret;
    } 
  }

  public byte FASTZOOM {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_FASTZOOM_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_FASTZOOM_get(swigCPtr);
      return ret;
    } 
  }

  public byte UCSICON {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_UCSICON_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_UCSICON_get(swigCPtr);
      return ret;
    } 
  }

  public byte GRIDMODE {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_GRIDMODE_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_GRIDMODE_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD GRIDUNIT {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_GRIDUNIT_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_GRIDUNIT_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public byte SNAPMODE {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPMODE_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPMODE_get(swigCPtr);
      return ret;
    } 
  }

  public byte SNAPSTYLE {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPSTYLE_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPSTYLE_get(swigCPtr);
      return ret;
    } 
  }

  public ushort SNAPISOPAIR {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPISOPAIR_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPISOPAIR_get(swigCPtr);
      return ret;
    } 
  }

  public double SNAPANG {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPANG_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPANG_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD SNAPBASE {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPBASE_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPBASE_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD SNAPUNIT {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPUNIT_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_SNAPUNIT_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public byte unknown {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_unknown_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public byte UCSVP {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_UCSVP_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_VPORT_UCSVP_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD ucs_origin {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_origin_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_origin_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD ucs_x_axis {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_x_axis_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_x_axis_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD ucs_y_axis {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_y_axis_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_y_axis_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double ucs_elevation {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_elevation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_elevation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort ucs_orthografic_type {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_orthografic_type_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_ucs_orthografic_type_get(swigCPtr);
      return ret;
    } 
  }

  public ushort grid_flags {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_grid_flags_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_grid_flags_get(swigCPtr);
      return ret;
    } 
  }

  public ushort grid_major {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_grid_major_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_VPORT_grid_major_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref null_handle {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_null_handle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_null_handle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref background {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_background_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_background_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref visualstyle {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_visualstyle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_visualstyle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref sun {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_sun_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_sun_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref named_ucs {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_named_ucs_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_named_ucs_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref base_ucs {
    set {
      LibreDWGPINVOKE.Dwg_Object_VPORT_base_ucs_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_VPORT_base_ucs_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_VPORT() : this(LibreDWGPINVOKE.new_Dwg_Object_VPORT(), true) {
  }

}
