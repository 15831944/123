//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Object_GEOMAPIMAGE : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Object_GEOMAPIMAGE(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Object_GEOMAPIMAGE obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Object_GEOMAPIMAGE() {
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
          LibreDWGPINVOKE.delete_Dwg_Object_GEOMAPIMAGE(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_Object parent {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_parent_set(swigCPtr, Dwg_Object_Object.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_parent_get(swigCPtr);
      Dwg_Object_Object ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_Object(cPtr, false);
      return ret;
    } 
  }

  public uint class_version {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_class_version_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_class_version_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Bitcode_3BD pt0 {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_pt0_set(swigCPtr, Dwg_Bitcode_3BD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_pt0_get(swigCPtr);
      Dwg_Bitcode_3BD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_3BD(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Bitcode_2RD size {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_size_set(swigCPtr, Dwg_Bitcode_2RD.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_size_get(swigCPtr);
      Dwg_Bitcode_2RD ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Bitcode_2RD(cPtr, false);
      return ret;
    } 
  }

  public ushort display_props {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_display_props_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_display_props_get(swigCPtr);
      return ret;
    } 
  }

  public byte clipping {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_clipping_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_clipping_get(swigCPtr);
      return ret;
    } 
  }

  public byte brightness {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_brightness_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_brightness_get(swigCPtr);
      return ret;
    } 
  }

  public byte contrast {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_contrast_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_contrast_get(swigCPtr);
      return ret;
    } 
  }

  public byte fade {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_fade_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_fade_get(swigCPtr);
      return ret;
    } 
  }

  public double rotation {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_rotation_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public double image_width {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_width_get(swigCPtr);
      return ret;
    } 
  }

  public double image_height {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_height_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_name_get(swigCPtr);
      return ret;
    } 
  }

  public double image_file {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_file_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_file_get(swigCPtr);
      return ret;
    } 
  }

  public double image_visibility {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_visibility_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_image_visibility_get(swigCPtr);
      return ret;
    } 
  }

  public ushort transparency {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_transparency_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_transparency_get(swigCPtr);
      return ret;
    } 
  }

  public double height {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_height_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_height_get(swigCPtr);
      return ret;
    } 
  }

  public double width {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_width_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_width_get(swigCPtr);
      return ret;
    } 
  }

  public byte show_rotation {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_show_rotation_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_show_rotation_get(swigCPtr);
      return ret;
    } 
  }

  public double scale_factor {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_scale_factor_set(swigCPtr, value);
    } 
    get {
      double ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_scale_factor_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geoimage_brightness {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_brightness_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_brightness_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geoimage_contrast {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_contrast_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_contrast_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geoimage_fade {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_fade_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_fade_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geoimage_position {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_position_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_position_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geoimage_width {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_width_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_width_get(swigCPtr);
      return ret;
    } 
  }

  public ushort geoimage_height {
    set {
      LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_height_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Object_GEOMAPIMAGE_geoimage_height_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Object_GEOMAPIMAGE() : this(LibreDWGPINVOKE.new_Dwg_Object_GEOMAPIMAGE(), true) {
  }

}