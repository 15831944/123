//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_MTEXT : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_MTEXT(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_MTEXT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_MTEXT() {
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
          LibreDWGPINVOKE.delete_Dwg_Entity_MTEXT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD insertion_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_insertion_pt_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_insertion_pt_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD extrusion {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_extrusion_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_extrusion_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD x_axis_dir {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_x_axis_dir_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_x_axis_dir_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double rect_height {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_rect_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_rect_height_get(swigCPtr);
      return ret;
    } 
  }

  public double rect_width {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_rect_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_rect_width_get(swigCPtr);
      return ret;
    } 
  }

  public double text_height {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_text_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_text_height_get(swigCPtr);
      return ret;
    } 
  }

  public ushort attachment {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_attachment_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_attachment_get(swigCPtr);
      return ret;
    } 
  }

  public ushort drawing_dir {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_drawing_dir_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_drawing_dir_get(swigCPtr);
      return ret;
    } 
  }

  public double extents_height {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_extents_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_extents_height_get(swigCPtr);
      return ret;
    } 
  }

  public double extents_width {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_extents_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_extents_width_get(swigCPtr);
      return ret;
    } 
  }

  public string text {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_text_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_text_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref style {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_style_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_style_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public ushort linespace_style {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_linespace_style_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_linespace_style_get(swigCPtr);
      return ret;
    } 
  }

  public double linespace_factor {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_linespace_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_linespace_factor_get(swigCPtr);
      return ret;
    } 
  }

  public byte unknown_bit {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_unknown_bit_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_unknown_bit_get(swigCPtr);
      return ret;
    } 
  }

  public uint bg_fill_flag {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_flag_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_flag_get(swigCPtr);
      return ret;
    } 
  }

  public uint bg_fill_scale {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_scale_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_scale_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Color bg_fill_color {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_color_set(swigCPtr, Dwg_Color.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_color_get(swigCPtr);
      Dwg_Color ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Color(cPtr, false);
      return ret;
    } 
  }

  public uint bg_fill_trans {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_trans_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_bg_fill_trans_get(swigCPtr);
      return ret;
    } 
  }

  public byte annotative {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_annotative_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_annotative_get(swigCPtr);
      return ret;
    } 
  }

  public ushort class_version {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_class_version_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public byte default_flag {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_default_flag_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_default_flag_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref appid {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_appid_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_appid_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public uint column_type {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_column_type_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_column_type_get(swigCPtr);
      return ret;
    } 
  }

  public double column_width {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_column_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_column_width_get(swigCPtr);
      return ret;
    } 
  }

  public double gutter {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_gutter_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_gutter_get(swigCPtr);
      return ret;
    } 
  }

  public byte auto_height {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_auto_height_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_auto_height_get(swigCPtr);
      return ret;
    } 
  }

  public byte flow_reversed {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_flow_reversed_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_flow_reversed_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_column_heights {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_num_column_heights_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Entity_MTEXT_num_column_heights_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double column_heights {
    set {
      LibreDWGPINVOKE.Dwg_Entity_MTEXT_column_heights_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_MTEXT_column_heights_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Entity_MTEXT() : this(LibreDWGPINVOKE.new_Dwg_Entity_MTEXT(), true) {
  }

}
