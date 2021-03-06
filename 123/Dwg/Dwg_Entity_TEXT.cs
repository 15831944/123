//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Entity_TEXT : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Entity_TEXT(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Entity_TEXT obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Entity_TEXT() {
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
          LibreDWGPINVOKE.delete_Dwg_Entity_TEXT(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Entity parent {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_parent_set(swigCPtr, Dwg_Object_Entity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_TEXT_parent_get(swigCPtr);
      Dwg_Object_Entity ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Entity(cPtr, false);
      return ret;
    } 
  }

  public byte dataflags {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_dataflags_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_dataflags_get(swigCPtr);
      return ret;
    } 
  }

  public double elevation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_elevation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_elevation_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_2BD insertion_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_insertion_pt_set(swigCPtr, Dwg_Bitcode_2BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_TEXT_insertion_pt_get(swigCPtr);
      Dwg_Bitcode_2BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2BD alignment_pt {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_alignment_pt_set(swigCPtr, Dwg_Bitcode_2BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_TEXT_alignment_pt_get(swigCPtr);
      Dwg_Bitcode_2BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD extrusion {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_extrusion_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_TEXT_extrusion_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double thickness {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_thickness_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_thickness_get(swigCPtr);
      return ret;
    } 
  }

  public double oblique_angle {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_oblique_angle_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_oblique_angle_get(swigCPtr);
      return ret;
    } 
  }

  public double rotation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public double height {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_height_get(swigCPtr);
      return ret;
    } 
  }

  public double width_factor {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_width_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_width_factor_get(swigCPtr);
      return ret;
    } 
  }

  public string text_value {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_text_value_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_text_value_get(swigCPtr);
      return ret;
    } 
  }

  public ushort generation {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_generation_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_generation_get(swigCPtr);
      return ret;
    } 
  }

  public ushort horiz_alignment {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_horiz_alignment_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_horiz_alignment_get(swigCPtr);
      return ret;
    } 
  }

  public ushort vert_alignment {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_vert_alignment_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Entity_TEXT_vert_alignment_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_Ref style {
    set {
      LibreDWGPINVOKE.Dwg_Entity_TEXT_style_set(swigCPtr, Dwg_Object_Ref.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Entity_TEXT_style_get(swigCPtr);
      Dwg_Object_Ref ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Ref(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Entity_TEXT() : this(LibreDWGPINVOKE.new_Dwg_Entity_TEXT(), true) {
  }

}
