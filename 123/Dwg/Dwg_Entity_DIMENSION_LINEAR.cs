//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_DIMENSION_LINEAR : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_DIMENSION_LINEAR(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_DIMENSION_LINEAR obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_DIMENSION_LINEAR() {
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
          LibreDWGPINVOKE.delete_Dwg_Entity_DIMENSION_LINEAR(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public byte class_version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_class_version_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public string blockname {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_blockname_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_blockname_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD extrusion {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_extrusion_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_extrusion_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD def_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_def_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_def_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD text_midpt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_text_midpt_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_text_midpt_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public double elevation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_elevation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_elevation_get(swigCPtr);
      return ret;
    } 
  }

  public byte flag {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flag_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flag_get(swigCPtr);
      return ret;
    } 
  }

  public byte flag1 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flag1_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flag1_get(swigCPtr);
      return ret;
    } 
  }

  public string user_text {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_user_text_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_user_text_get(swigCPtr);
      return ret;
    } 
  }

  public double text_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_text_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_text_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public double horiz_dir {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_horiz_dir_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_horiz_dir_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD ins_scale {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_ins_scale_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_ins_scale_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double ins_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_ins_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_ins_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attachment {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_attachment_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_attachment_get(swigCPtr);
      return ret;
    } 
  }

  public ushort lspace_style {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_lspace_style_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_lspace_style_get(swigCPtr);
      return ret;
    } 
  }

  public double lspace_factor {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_lspace_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_lspace_factor_get(swigCPtr);
      return ret;
    } 
  }

  public double act_measurement {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_act_measurement_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_act_measurement_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_unknown_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_unknown_get(swigCPtr);
      return ret;
    } 
  }

  public byte flip_arrow1 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flip_arrow1_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flip_arrow1_get(swigCPtr);
      return ret;
    } 
  }

  public byte flip_arrow2 {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flip_arrow2_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_flip_arrow2_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD clone_ins_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_clone_ins_pt_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_clone_ins_pt_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref dimstyle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_dimstyle_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_dimstyle_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Object_Ref block {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_block_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_block_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD xline1_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_xline1_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_xline1_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD xline2_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_xline2_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_xline2_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double oblique_angle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_oblique_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_oblique_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double dim_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_dim_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_DIMENSION_LINEAR_dim_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Entity_DIMENSION_LINEAR() : this(LibreDWGPINVOKE.new_Dwg_Entity_DIMENSION_LINEAR(), true) {
  }

}
