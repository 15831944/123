//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_ACSH_SWEEP_CLASS : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_ACSH_SWEEP_CLASS(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_ACSH_SWEEP_CLASS obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_ACSH_SWEEP_CLASS() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_ACSH_SWEEP_CLASS(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public uint ee_bl98 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_ee_bl98_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_ee_bl98_get(swigCPtr);
      return ret;
    } 
  }

  public uint ee_bl99 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_ee_bl99_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_ee_bl99_get(swigCPtr);
      return ret;
    } 
  }

  public uint shhn_bl98 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_bl98_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_bl98_get(swigCPtr);
      return ret;
    } 
  }

  public uint shhn_bl99 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_bl99_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_bl99_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double shhn_pts {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_pts_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_pts_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Color color {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public byte shhn_b92 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_b92_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_b92_get(swigCPtr);
      return ret;
    } 
  }

  public uint shhn_bl347 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_bl347_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shhn_bl347_get(swigCPtr);
      return ret;
    } 
  }

  public uint shsw_bl90 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl90_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl90_get(swigCPtr);
      return ret;
    } 
  }

  public uint shsw_bl91 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl91_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl91_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD basept {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_basept_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_basept_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public uint shsw_bl92 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl92_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl92_get(swigCPtr);
      return ret;
    } 
  }

  public uint shsw_size_text {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_size_text_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_size_text_get(swigCPtr);
      return ret;
    } 
  }

  public string shsw_text {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_text_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_text_get(swigCPtr);
      return ret;
    } 
  }

  public uint shsw_bl93 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl93_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_bl93_get(swigCPtr);
      return ret;
    } 
  }

  public uint shsw_size_text2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_size_text2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_size_text2_get(swigCPtr);
      return ret;
    } 
  }

  public string shsw_text2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_text2_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_text2_get(swigCPtr);
      return ret;
    } 
  }

  public double draft_angle {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_draft_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_draft_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double start_draft_dist {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_start_draft_dist_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_start_draft_dist_get(swigCPtr);
      return ret;
    } 
  }

  public double end_draft_dist {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_end_draft_dist_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_end_draft_dist_get(swigCPtr);
      return ret;
    } 
  }

  public double scale_factor {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_scale_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_scale_factor_get(swigCPtr);
      return ret;
    } 
  }

  public double twist_angle {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_twist_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_twist_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double align_angle {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_align_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_align_angle_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double sweepentity_transform {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_sweepentity_transform_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_sweepentity_transform_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double pathentity_transform {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_pathentity_transform_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_pathentity_transform_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public byte align_option {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_align_option_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_align_option_get(swigCPtr);
      return ret;
    } 
  }

  public byte miter_option {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_miter_option_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_miter_option_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_align_start {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_has_align_start_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_has_align_start_get(swigCPtr);
      return ret;
    } 
  }

  public byte bank {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_bank_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_bank_get(swigCPtr);
      return ret;
    } 
  }

  public byte check_intersections {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_check_intersections_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_check_intersections_get(swigCPtr);
      return ret;
    } 
  }

  public byte shsw_b294 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_b294_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_b294_get(swigCPtr);
      return ret;
    } 
  }

  public byte shsw_b295 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_b295_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_b295_get(swigCPtr);
      return ret;
    } 
  }

  public byte shsw_b296 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_b296_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_shsw_b296_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD pt2 {
    set {
      LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_pt2_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_ACSH_SWEEP_CLASS_pt2_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_ACSH_SWEEP_CLASS() : this(LibreDWGPINVOKE.new_Dwg_Object_ACSH_SWEEP_CLASS(), true) {
  }

}
