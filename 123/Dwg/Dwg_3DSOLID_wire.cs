//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_3DSOLID_wire : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_3DSOLID_wire(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_3DSOLID_wire obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_3DSOLID_wire() {
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
          LibreDWGPINVOKE.delete_Dwg_3DSOLID_wire(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Entity__3DSOLID parent {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_parent_set(swigCPtr, Dwg_Entity__3DSOLID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_3DSOLID_wire_parent_get(swigCPtr);
      Dwg_Entity__3DSOLID ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Entity__3DSOLID(cPtr, false);
      return ret;
    } 
  }

  public byte type {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_type_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_type_get(swigCPtr);
      return ret;
    } 
  }

  public uint selection_marker {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_selection_marker_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_selection_marker_get(swigCPtr);
      return ret;
    } 
  }

  public ushort color {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_color_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_color_get(swigCPtr);
      return ret;
    } 
  }

  public uint acis_index {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_acis_index_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_acis_index_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_points {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_num_points_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_num_points_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD points {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_points_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_3DSOLID_wire_points_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public byte transform_present {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_transform_present_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_transform_present_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD axis_x {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_axis_x_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_3DSOLID_wire_axis_x_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD axis_y {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_axis_y_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_3DSOLID_wire_axis_y_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD axis_z {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_axis_z_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_3DSOLID_wire_axis_z_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD translation {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_translation_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_3DSOLID_wire_translation_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public double scale {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_scale_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_scale_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_rotation {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_has_rotation_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_has_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_reflection {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_has_reflection_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_has_reflection_get(swigCPtr);
      return ret;
    } 
  }

  public byte has_shear {
    set {
      LibreDWGPINVOKE.Dwg_3DSOLID_wire_has_shear_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_3DSOLID_wire_has_shear_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_3DSOLID_wire() : this(LibreDWGPINVOKE.new_Dwg_3DSOLID_wire(), true) {
  }

}
